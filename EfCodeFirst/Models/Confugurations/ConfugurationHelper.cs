using EfCodeFirst.Models.Common;
using EfCodeFirst.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCodeFirst.Models.Configurations
{
    // Extention yazmaq ucun class ve metod static olmalidir
    public static class ConfigurationHelper
    {
        // Burada "T" evezine Diger Class ola bilerdi meselen "Size" lakin butun classlar da isleneceyine gore "T" generic ile evez edilib
        // "where T" - Class oldugunu bildirir
        // " : AuditableEntity " - Proporty-lere el catmasi ucun miras verilir
        public static void ConfigureAuditable<T>(this EntityTypeBuilder<T> builder)
            where T : AuditableEntity
        {
            builder.Property(m => m.CreatedAt).HasColumnType("datetime").IsRequired();
            builder.Property(m => m.CreatedBy).HasColumnType("int");

            builder.Property(m => m.LastModifiedAt).HasColumnType("datetime");
            builder.Property(m => m.LastModifiedBy).HasColumnType("int");

            builder.Property(m => m.DeletedAt).HasColumnType("datetime");
            builder.Property(m => m.DeletedBy).HasColumnType("int");
        }
    }
}

