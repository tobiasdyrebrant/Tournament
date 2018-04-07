using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Tournament.API
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Middleware
    {
        private readonly RequestDelegate _next;

        public Middleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            //TODO
            //Fixa lite med authentification
            httpContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            httpContext.Response.Headers.Add("Access-Control-Allow-Methods", new[] { "GET, POST, OPTIONS" });
            httpContext.Response.Headers.Add("Access-Control-Allow-Headers", new[] { "Content-Type" });
            await _next(httpContext);            
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Middleware>();
        }
    }
}
