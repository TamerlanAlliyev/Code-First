using EfCodeFirst.Models.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace EfCodeFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Sql ve ya console-de giris ve cixis herflerinin az sriftlerini qebul edilmesi ucun
            // Console.InputEncoding = Encoding.Unicode;   // Daxil unicode etmek ucun
            // Console.OutputEncoding = Encoding.Unicode;  // Cixan cavabi unicode gormek ucun


            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
             
            builder.Services.AddDbContext<DataContext>(cfg =>
            {
                cfg.UseSqlServer(builder.Configuration.GetConnectionString("cString"), option =>
                {
                    // sql-de yaranmis tablenin default adini burda duzeldilir
                    option.MigrationsHistoryTable("Migration");

                    // sql-e geden sorgunun nece ssaniye gozledilmesi
                    // option.CommandTimeout(15); // 15 saniye

                });
            });


            var app = builder.Build();

            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}