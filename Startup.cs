﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;


namespace AspNetCoreCliDemo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        	services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
        	app.UseDeveloperExceptionPage();
        	app.UseStaticFiles();
        	app.UseMvcWithDefaultRoute();
        }

        // This doesn't work right now, as it can't resolve WebApplication type
        //public static void Main(string[] args) => WebApplication.Run<Startup>(args);

        // Entry point for the application.
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                        .UseDefaultHostingConfiguration(args)
                        .UseIISPlatformHandlerUrl()
                        .UseKestrel()
                        .UseStartup<Startup>()
                        .Build();

            host.Run();
        }
    }
}	