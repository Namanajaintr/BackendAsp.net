
using CQRS_WEB_API.Extensions;
using CQRS_WEB_API.Repository.Modal;
using CQRS_WEB_API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace CQRS_WEB_API
{
    public class Startup
    {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {

            services.AddControllers();

            services.AddCors();

            services.AddCors(options => {
                options.AddDefaultPolicy(
                    builder => {
                        builder.WithOrigins("https://localhost:44351", "http://localhost:4200")
                                            .AllowAnyHeader()
                                            .AllowAnyMethod();
                    });
            });

            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CQRS_WEB_API", Version = "v1" });
            });

            services.AddScoped<ICarRepo, SqlCarRepo>();

            services.AddDbContext<CarDbContext>(x => x.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {

            app.ConfigureExceptionhandler(env);

            //if (env.IsDevelopment()) {
            //    app.UseDeveloperExceptionPage();
            //    app.UseSwagger();
            //    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CQRS_WEB_API v1"));
            //}
            //else {
            //    app.UseExceptionHandler(
            //         options => {
            //             options.Run(
            //                 async context => {
            //                     context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            //                     context.Response.ContentType = "text/html";
            //                     var exceptionObject = context.Features.Get<IExceptionHandlerFeature>();
            //                     if (null != exceptionObject) {
            //                         await context.Response.WriteAsync(exceptionObject.Error.Message);
            //                     }
            //                 });
            //         }
            //     );
            //}

            // in general
            app.UseCors();
            // Shows UseCors with CorsPolicyBuilder.
            app.UseCors(builder =>
            {
                builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            });

            

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }

        
    }
}
