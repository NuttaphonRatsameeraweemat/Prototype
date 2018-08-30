using Prototype.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
            services.ConfigureRepository(Configuration);
            services.ConfigureBll();
            services.ConfigureLoggerService();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.ConfigureMiddleware();

            app.UseMvc();
        }
    }
}
