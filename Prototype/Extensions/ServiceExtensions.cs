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
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Http;

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

        /// <summary>
        /// Add Jwt Authentication and Setting.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="Configuration"></param>
        public static void ConfigureJwtAuthen(this IServiceCollection services, IConfiguration Configuration)
        {
            var option = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ClockSkew = System.TimeSpan.Zero,
                ValidIssuer = Configuration["Jwt:Issuer"],
                ValidAudience = Configuration["Jwt:Issuer"],
                IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
            };
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
             .AddJwtBearer(options =>
             {
                 options.TokenValidationParameters = option;
                 options.Events = new JwtBearerEvents
                 {
                     OnAuthenticationFailed = context =>
                     {
                         context.Response.StatusCode = (int)System.Net.HttpStatusCode.Unauthorized;
                         var model = new
                         {
                             context.Response.StatusCode,
                             Message = "Unauthorized."
                         };
                         string json = JsonConvert.SerializeObject(model, new JsonSerializerSettings
                         {
                             ContractResolver = new CamelCasePropertyNamesContractResolver()
                         });
                         context.Response.OnStarting(async () =>
                         {
                             context.Response.ContentType = "application/json";
                             await context.Response.WriteAsync(json);
                         });
                         return System.Threading.Tasks.Task.CompletedTask;
                     },
                 };
             });
        }

    }
}
