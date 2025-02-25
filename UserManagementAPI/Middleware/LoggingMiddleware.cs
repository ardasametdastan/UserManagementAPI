using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace UserManagementAPI.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            // Loglama işlemi burada yapılabilir
            Console.WriteLine($"[{DateTime.Now}] {httpContext.Request.Method} {httpContext.Request.Path}");
            await _next(httpContext);
        }
    }
}
