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
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync(
            //           "Hello World !!"
            //            );
            //    });
            //});

            //// this class helps us to override default options
            //DefaultFilesOptions df = new DefaultFilesOptions();
            //df.DefaultFileNames.Clear();// clear all default ones...
            //df.DefaultFileNames.Add("foo.html");// now foo.html is the only default file

            //app.UseDefaultFiles(df); // thats it,,,lets see the output now,,
            //app.UseStaticFiles();

            //// and then 
            //app.UseDirectoryBrowser();

            app.UseFileServer(enableDirectoryBrowsing:true);// by default directory browsing is not enabled in this

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(env.ContentRootPath, "staticfiles")
                    ),
                RequestPath = "/StaticFiles"               
                
            });

        }
    }
}
