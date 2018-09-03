using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Prototype.Data.Repository.Interfaces;
using Prototype.Data;
using Microsoft.EntityFrameworkCore;
using Prototype.Bll.Interfaces;
using Prototype.Bll;
using Prototype.Helper.Interfaces;
using Prototype.Helper;
using Microsoft.AspNetCore.Builder;

namespace Prototype.Extensions
{
    public static class ServiceExtensions
    {
        /// <summary>
        /// Dependency Injection Repository and UnitOfWork.
        /// </summary>
        /// <param name="services">The service collection.</param>
        /// <param name="Configuration">The configuration from settinfile.</param>
        public static void ConfigureRepository(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddEntityFrameworkSqlServer()
             .AddDbContext<DSDBContext>(options =>
              options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));

            services.AddTransient<IUnitOfWork, PtUnitOfWork>();
        }

        /// <summary>
        /// Dependency Injection Class Business Logic Layer.
        /// </summary>
        /// <param name="services">The service collection.</param>
        public static void ConfigureBll(this IServiceCollection services)
        {
            services.AddScoped<IHrEmployee, HrEmployee>();
        }

        /// <summary>
        /// Add Singletion Logger Class
        /// </summary>
        /// <param name="services">The service collection.</param>
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }

        /// <summary>
        /// Add Middleware when request bein and end.
        /// </summary>
        /// <param name="app"></param>
        public static void ConfigureMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<Middleware>();
        }

    }
}
