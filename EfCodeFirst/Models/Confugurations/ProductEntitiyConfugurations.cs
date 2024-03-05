using EfCodeFirst.Models.Configurations;
using EfCodeFirst.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCodeFirst.Models.Confugurations
{
    public class ProductEntitiyConfugurations : IEntityTypeConfiguration<Product>
    {

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int").UseIdentityColumn(1, 1);
            builder.Property(m => m.Name).HasColumnType("nvarchar").HasMaxLength(250).IsRequired();
            builder.Property(m => m.Slug).HasColumnType("varchar").HasMaxLength(250).IsRequired();
            builder.Property(m => m.StockKeepingUnit).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(m => m.ShortDescription).HasColumnType("nvarchar").HasMaxLength(300).IsRequired();
            builder.Property(m => m.Description).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(m => m.Rate).HasColumnType("decimal").HasPrecision(3,2).IsRequired();
            builder.Property(m => m.CategoryId).HasColumnType("int").IsRequired();
            builder.Property(m => m.BrandId).HasColumnType("int").IsRequired();



            builder.ConfigureAuditable();

            builder.HasKey(m => m.Id);
            builder.HasIndex(m => m.Slug).IsUnique(); // "Slug" eyni adda olmasin deye Uniqe edilir ve ozu sqlde indeks yaratmis olur
            builder.ToTable("Products");


            builder.HasOne<Category>()
                .WithMany()
                .HasPrincipalKey(m => m.Id)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Brand>()
                .WithMany()
                .HasPrincipalKey(m => m.Id)
                .HasForeignKey(m => m.BrandId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
