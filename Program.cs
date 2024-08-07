using Microsoft.EntityFrameworkCore;
using Tp_Barengo.Models;

namespace Tp_Barengo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            builder .Services.AddDbContext<LibrosContext>(options =>   // Conexion de JSON
            options.UseSqlServer(builder.Configuration.GetConnectionString("Conexion")));
 // una vez editado este codigo (https://learn.microsoft.com/es-es/ef/core/miscellaneous/connection-strings), se habra mapeado la base de datos de sql

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
