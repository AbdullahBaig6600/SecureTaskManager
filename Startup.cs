using Microsoft.EntityFrameworkCore;
using SecureTaskManager.Data;

namespace SecureTaskManager
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method is used to configure services (Dependency Injection)
        public void ConfigureServices(IServiceCollection services)
        {
            // Add MVC services
            services.AddControllersWithViews();

            // Add Entity Framework Core with SQL Server
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));
        }

        // This method is used to configure the HTTP request pipeline (Middleware)
        public void Configure(WebApplication app)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
