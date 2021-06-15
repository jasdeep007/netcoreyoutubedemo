using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
            // for directory browsing, we need to add directory browsing service
            //services.AddDirectoryBrowser();
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


            app.Run(async (context) => {
                await context.Response.WriteAsync($"Current Environment is : {env.EnvironmentName}");
            });

        }
    }
}
