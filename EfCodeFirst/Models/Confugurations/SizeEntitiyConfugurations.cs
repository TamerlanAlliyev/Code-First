using EfCodeFirst.Models.Configurations;
using EfCodeFirst.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCodeFirst.Models.Confugurations
{
    public class SizeEntitiyConfugurations : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.Property(m=>m.Id).HasColumnType("int").UseIdentityColumn(1,1);
            builder.Property(m => m.Name).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(m=>m.SmallName).HasColumnType("varchar").HasMaxLength(5).IsRequired();

            builder.ConfigureAuditable();

            builder.HasKey(m=>m.Id);
            builder.ToTable("Sizes");
        }
    }

}