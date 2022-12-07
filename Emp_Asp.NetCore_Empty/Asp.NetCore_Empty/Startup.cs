using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Asp.NetCore_Empty.Modal;

namespace Asp.NetCore_Empty
{
    public class Startup
    {
        //Constructor Dependency Injection
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }



        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) {
            services.AddControllersWithViews();

            //contains all the dependencies of the mvc
            services.AddMvc().AddXmlDataContractSerializerFormatters();

            //
            //services.AddMvcCore();

            //creating a relationship bn IEmployee and MockEmployee 
            services.AddSingleton<IEmployee, MockEmployee>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            //if we want to render our own default page we need to create an object of defaultFileOptions
            DefaultFilesOptions defaultFiles = new DefaultFilesOptions();
            defaultFiles.DefaultFileNames.Clear();
            defaultFiles.DefaultFileNames.Add("landing.html");
            
            //returns default.html/default.htm/index.html/index.htm files
            //app.UseDefaultFiles(defaultFiles);

            FileServerOptions fileServer = new FileServerOptions();
            fileServer.EnableDefaultFiles = true;
            fileServer.StaticFileOptions.RedirectToAppendTrailingSlash = true;
            fileServer.DefaultFilesOptions.DefaultFileNames.Clear();
            fileServer.DefaultFilesOptions.DefaultFileNames.Add("landing.html");
            

            //is the combination of usestatic and usedefault
            //app.UseFileServer(fileServer);

            //Returns the reference from the endpoints
            app.UseRouting();

            //To acces the static files inside the wwwroot folder
            app.UseStaticFiles();

            //app.UseAuthentication();

            //app.UseAuthorization();

            app.UseEndpoints(endpoints => {
               // endpoints.MapGet("/", async context => {
                    //private_key in appsettings.json is overriden by
                    //appsettings.development.json is overriden by
                    //launchsettings.json is overriden
                    //by giving private_key thro CLI 
                   // await context.Response.WriteAsync(Configuration["Private_Key"]);
                    //await context.Response.WriteAsync(env.EnvironmentName+"this is the environmental variable");

                    endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}