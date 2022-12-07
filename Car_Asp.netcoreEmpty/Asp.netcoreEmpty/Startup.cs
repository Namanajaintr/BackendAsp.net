using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.netcoreEmpty.Modal;

namespace Asp.netcoreEmpty
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) {
            services.AddControllersWithViews();
            //contains all the dependencies of the mvc
            //converts json to Xml
            services.AddMvc().AddXmlDataContractSerializerFormatters();

            //creating a relationship bn IEmployee and MockEmployee 
            //services.AddSingleton<ICar, CarDetails>();
            //services.AddTransient<ICar, CarDetails>();
            services.AddScoped<ICar, CarDetails>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }
            else {
                //UseStatusCodePagesWithRedirects: Send 302 to Client.
                //UseStatusCodePagesWithReExecute: Send Original Status Code and Executes handler for redirect URL
                app.UseStatusCodePages();
                app.UseStatusCodePagesWithRedirects("~/Error/{0}.html");
                app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");

            }

            app.UseRouting();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Details}/{Car_No?}");
            });

            //app.UseMvc(routes => { routes.MapRoute("default", "{controller}/{action}/{id}")
            //    });
            //Enabling attribute routing 
            //app.MapMvcAttributeRoutes();
        }
    }
}
