
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
    using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1
    {
        public class Startup
        {
            public IConfiguration Configuration { get; }
            public IWebHostEnvironment WebHost { get; }

            public Startup(IConfiguration configuration, IWebHostEnvironment webHost)
            {
                Configuration = configuration;
                WebHost = webHost;
            }
            public void ConfigureServices(IServiceCollection services)
            {
                //services.AddMvc();
                services.AddControllersWithViews();

                services.AddDbContext<WebApplication1Context>(options =>
                        options.UseSqlServer(Configuration.GetConnectionString("WebApplication1Context")));

     
        }

            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
                //if (env.IsDevelopment())
                //{
                //    app.UseDeveloperExceptionPage(); //Middleware Error Handling
                //}
                app.UseDefaultFiles(); //Default.html -- Index.html --
                app.UseStaticFiles(); //Look inside wwroot folder
                app.UseRouting(); //RoutingTable -- Rows //Middleware Routing

                app.UseEndpoints(endpoints => //Add Entries to routing table
                {
                    endpoints.MapDefaultControllerRoute();

                    endpoints.MapGet("/", async context =>
                    {
                        await context.Response.WriteAsync("Hello World!");
                    });
                });
            }

        }
    }
