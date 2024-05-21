using Meetup.DAL;
using Microsoft.EntityFrameworkCore;
using System;

namespace Meetup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<MtContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Meetup"))
);
            var app = builder.Build();
            app.UseStaticFiles();

            app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Product}/{action=Index}/{id?}"
          );
            app.MapControllerRoute("Default", "{Controller=home}/{Action=index}");

            app.Run();
        }
    }
}
