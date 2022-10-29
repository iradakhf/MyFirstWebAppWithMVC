using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //here helper libraries, for instance the database.
            //Here we write the things that we want our project to run and work together with our project
            //when it is run.

            services.AddControllersWithViews();  
            //we will copy and paste html, css and js to view file and with this way we will build client side on server.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=index}/{id?}/{name?}/{surname?}");
                 

                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});

                // any external object is turned into the needed structure by use of map. 
                //endpoints.MapGet("/p228firstendpoint", async context2 => {
                //    await context2.Response.WriteAsync("my first endpoint");
                //});


            });
        }
    }
}

/*
         public void Cofigure(IApplicationBuilder app, IWebHostEnvironment env)
         {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
         }
    
      
    here we will add additional settings to control the services. 
 
 */

//What is endpoint?
//Domain is Ip and it remains. But inside an application there may be different methods
//(For instance, create a group or delete a group) 
//This kind of functionalities are different and thus they are individual endpoints(i.e The last point of the request)



