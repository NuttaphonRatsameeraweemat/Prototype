using Prototype.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;

namespace Prototype
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            NLog.LogManager.LoadConfiguration(string.Concat(System.IO.Directory.GetCurrentDirectory(),"/nlog.config"));
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Add Configure Extension and Bll class.
            services.ConfigureRepository(Configuration);
            services.ConfigureBll();
            services.ConfigureLoggerService();
            services.ConfigureJwtAuthen(Configuration);

            services.AddAutoMapper();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();

            app.ConfigureMiddleware();

            app.UseMvc();
        }
    }
}
