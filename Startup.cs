using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace youtubedemonetcore
{
    public class Startup
    {
        private readonly IConfiguration config;
        public Startup(IConfiguration _config)
        {
            config = _config;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // to use MVC in .net core , we need to use MVC service
            // Now we have 2 service one is MVC and MVCCore
            // The difference is that MVC is the parent of MVC core and MVC
            // uses MVCCore inside...

            //services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddControllersWithViews (options => options.EnableEndpointRouting = false);

        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment() ||
                env.IsProduction() ||
                env.IsStaging() ||
                env.IsEnvironment("UAT"))
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            // we are using with default routes that is controller/action/id
            // that you can also see in old .net MVC
            // Also use it after use static files middleware
            // because for static files we do not want any routing
            app.UseStaticFiles();
            // because we do add any routing now
            // lets add it
            app.UseMvcWithDefaultRoute();

            app.Run(async (context) => {
                await context.Response.WriteAsync($"Current Environment is : {env.EnvironmentName}");
            });

        }
    }
}
