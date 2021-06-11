using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
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
        }
        private static void executethiscode(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Write code in response because /outtm was requested");
            });
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
                // don't worry we will study it,,
                // its just example that we can use custom page for exception
                // because of this middleware
            }

            ////// lets try to make simple middleware by use method            
            ////// use method allows current middleware to be executed and also next code
            ////app.Use(async (context, next) =>
            ////{
            ////    await context.Response.WriteAsync("(Request) I am from middleware by run method 1 \n");
            ////    await next.Invoke();
            ////    await context.Response.WriteAsync("(Response) I am from middleware by run method 1 \n");
            ////});
            ////// lets make another middleware with use
            ////app.Use(async (context, next) =>
            ////{
            ////    await context.Response.WriteAsync("(Request) I am from middleware by run method 2 \n");
            ////    await next.Invoke();
            ////    await context.Response.WriteAsync("(Response) I am from middleware by run method 2 \n");

            ////});
            //////lets make another but this time by run method
            ////app.Run(async (context) =>
            ////{
            ////    await context.Response.WriteAsync("(Request) I am from middleware by run method 3 \n");
            ////    await context.Response.WriteAsync("(Response) I am from middleware by run method 3 \n");
            ////});

            //app.MapWhen(context => {
            //    return context.Request.Query.ContainsKey("somekey"); // when query string contains key then execute below delegate
            //}, executethiscode);
            app.Map("/outtm", executethiscode);
            

            app.UseRouting(); // for routing 

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync(
                        "I am after middleware code"
                        );
                });
            });
        }
    }
}
