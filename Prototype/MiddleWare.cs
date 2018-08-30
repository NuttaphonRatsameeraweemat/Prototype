using Microsoft.AspNetCore.Http;
using Prototype.Helper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prototype
{
    public class Middleware
    {
        private readonly RequestDelegate _next;
        private readonly ILoggerManager _logger;

        public Middleware(RequestDelegate next, ILoggerManager logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex);
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)System.Net.HttpStatusCode.InternalServerError;

            return context.Response.WriteAsync(new
            {
                context.Response.StatusCode,
                Message = "Internal Server Error."
            }.ToString());
        }
    }
}
