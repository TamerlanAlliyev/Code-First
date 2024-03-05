using EfCodeFirst.Models.Configurations;
using EfCodeFirst.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCodeFirst.Models.Confugurations
{
    public class CategoryEntitiyConfugurations:IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(m=>m.Id).HasColumnType("int").UseIdentityColumn(1,1);
            builder.Property(m=>m.ParentId).HasColumnType("int");
            builder.Property(m=>m.Name).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();

            builder.ConfigureAuditable();

            builder.HasKey(m => m.Id);
            builder.ToTable("Categories");


            builder.HasOne<Category>() // Evez edəcəyi növü təyin edir
                   .WithMany() // Bir çoxuna malikdir
                   .HasPrincipalKey(m => m.Id) // Əsas açarı təyin edir
                   .HasForeignKey(m => m.ParentId) // Xarici açarı təyin edir
                   .OnDelete(DeleteBehavior.NoAction); // Silmə əməliyyatını təyin edir (Hər hansısa bir əməliyyat etmə) 

        }
    }
}
