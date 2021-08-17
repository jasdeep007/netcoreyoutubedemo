using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using youtubedemonetcore.authorization;
using youtubedemonetcore.configclasses;
using youtubedemonetcore.db;
using youtubedemonetcore.Hubs;
using youtubedemonetcore.models;

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
            // now we define connection string,,
            // so that it will know what database to connect
            services.AddDbContextPool<dbOperations>(
                options => options.UseSqlServer(config.GetConnectionString("dbconnectionstring"))
                );

            // we use configure here to tell .net core about ConnectionStrings class
            services.Configure<ConnectionStrings>(
                a => config.GetSection(nameof(ConnectionStrings)).Bind(a)
                );
          

            // nothing to do here,, bcs class is already bind








            // also we will take connection string from 
            // app setting... using predefined json attribute
            // lets define connection string quickly

            services.AddSingleton<Iusers, chatuserscount>();
            services.AddSingleton<tokenverify>(); // lets build it
            services.AddSingleton<IcheckToken, CheckToken>();

            services.AddScoped<IEmployee, EmployeeRepository>();

            //services.AddScoped<IEmployee, EmployeeRepository>();
            //services.AddTransient<IEmployee, EmployeeRepository>();

            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddSignalR();
            //services.AddControllersWithViews (options => options.EnableEndpointRouting = false);

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
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapHub<ChatHub>("/chatHub");
            });
            // because we do add any routing now
            // lets add it
            app.UseMvcWithDefaultRoute();

            //app.Run(async (context) => {
            //    await context.Response.WriteAsync($"Current Environment is : {env.EnvironmentName}");
            //});

        }
    }
}
