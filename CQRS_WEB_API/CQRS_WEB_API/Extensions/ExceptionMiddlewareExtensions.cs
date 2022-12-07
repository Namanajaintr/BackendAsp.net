using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CQRS_WEB_API.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionhandler(this IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CQRS_WEB_API v1"));
            }
            else {
                app.UseExceptionHandler(
                     options => {
                         options.Run(
                             async context => {
                                 context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                                 context.Response.ContentType = "text/html";
                                 var exceptionObject = context.Features.Get<IExceptionHandlerFeature>();
                                 if (null != exceptionObject) {
                                     await context.Response.WriteAsync(exceptionObject.Error.Message);
                                 }
                             });
                     }
                 );
            }
        }
    }
}
