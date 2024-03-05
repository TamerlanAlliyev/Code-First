using EfCodeFirst.Models.Configurations;
using EfCodeFirst.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCodeFirst.Models.Confugurations
{
    public class BlogPostEntitiyConfugurations : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int").UseIdentityColumn(1, 1);
            builder.Property(m => m.Title).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(m => m.Slug).HasColumnType("varchar").HasMaxLength(150).IsRequired();
            builder.Property(m => m.Body).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(m => m.ImagePath).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            builder.Property(m => m.PublishedAt).HasColumnType("datetime");
            builder.Property(m => m.PublishedBy).HasColumnType("int");


            builder.ConfigureAuditable();

            builder.HasKey(m => m.Id);
            builder.ToTable("BlogPosts");

            // ForeignKey elaqenin qurulmasi.   Asili olan tablenin icerisinde yazilir
            builder.HasOne<Category>()  // hansi table-e baglanirsa onun table adi yazilir
                .WithMany() // hansi table aslidir o yazilir
                .HasForeignKey(c => c.CategoryId) // foreignkey hansi proporty(column) - dirse onun adi yazilir
                .HasPrincipalKey(c => c.Id) // Foreignkey asili oldugu tablenin hansi primary keyi ile elaqe quracaqi column yazilir
                .OnDelete(DeleteBehavior.NoAction); // Bu kodda "NoAction" egerki Esas Tablede "Category" de her hansisa bir row silinerse BlogPosta ki hemin deyeri silinmesinin qarsisi alinir
        }
    }
}
