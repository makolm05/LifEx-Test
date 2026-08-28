using LifEx.Infrastructure.DbContexts;
using LifEx.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

namespace LifEx.API.Helpers
{
    public static class Startup
    {

        public static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddDbContext<LifExDbContext>(options =>
            {
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddControllersWithViews();
            services.AddScoped<LifExDbContext>();
            services.AddScoped<ILifExRepository, LifExRepository>();
        }
    

        public static void ConfigureApplication(WebApplication app)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Welcome}");
        }
    }
}