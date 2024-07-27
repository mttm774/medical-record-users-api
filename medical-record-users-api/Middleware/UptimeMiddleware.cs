using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
namespace medical_record_users_api.Middleware
{
    public class UptimeMiddleware
    {
        private static readonly DateTime _startTime = DateTime.UtcNow;

        private readonly RequestDelegate _next;

        public UptimeMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Pass the request to the next middleware component
            await _next(context);
        }

        public static TimeSpan GetUptime()
        {
            return DateTime.UtcNow - _startTime;
        }
    }
}