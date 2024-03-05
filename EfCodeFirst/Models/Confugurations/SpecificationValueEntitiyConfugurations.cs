using EfCodeFirst.Models.Configurations;
using EfCodeFirst.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCodeFirst.Models.Confugurations
{
    public class SpecificationValueEntitiyConfugurations : IEntityTypeConfiguration<SpecificationValue>
    {
        public void Configure(EntityTypeBuilder<SpecificationValue> builder)
        {
            // "SpecificationId" ve "ProductId" ikisi birlikde primarykey dir
            builder.Property(m => m.SpecificationId).HasColumnType("int");
            builder.Property(m => m.ProductId).HasColumnType("int");

            builder.Property(m => m.Value).HasColumnType("varchar").HasMaxLength(150).IsRequired();

            // 2 primary keyi yazmaq ucun tek bir HasKey daxilinde obyekt kimi qeyd olunur
            builder.HasKey(m => new { m.ProductId, m.SpecificationId });    // composite primary key adlanir 
            builder.ToTable("SpecificationValues");



            builder.HasOne<Specification>()
                .WithMany()
                .HasPrincipalKey(m=>m.Id)
                .HasForeignKey(m => m.SpecificationId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Product>()
                .WithMany()
                .HasPrincipalKey(m=>m.Id)
                .HasForeignKey(m => m.ProductId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

}