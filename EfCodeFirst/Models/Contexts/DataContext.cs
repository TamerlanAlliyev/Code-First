using EfCodeFirst.Models.Confugurations;
using EfCodeFirst.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfCodeFirst.Models.Contexts
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions option) : base(option)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.ApplyConfiguration(new SizeEntitiyConfugurations());
        //    modelBuilder.ApplyConfiguration(new ColorEntitiyConfugurations());
        //    modelBuilder.ApplyConfiguration(new BrandEntitiyConfugurations());
        //    modelBuilder.ApplyConfiguration(new BlogPostEntitiyConfugurations());
        //    modelBuilder.ApplyConfiguration(new CategoryEntitiyConfugurations());

        //    var currentAssembly = typeof(DataContext).Assembly;
        //    modelBuilder.ApplyConfigurationsFromAssembly(currentAssembly);
        //}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var currentAssembly = typeof(DataContext).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(currentAssembly);
        }


        public DbSet<Size> Sizes { get; set; }
    }
}
