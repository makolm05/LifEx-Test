using LifEx.Infrastructure.Services;
using LifEx.Infrastructure.DbContexts;

namespace LifEx.API.Helpers
{
    public class Startup
    {

        public static void ConfigureServices(IServiceCollection services)
        {
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
                pattern: "{controller=Home}/{action=Index}");
        }
    }
}