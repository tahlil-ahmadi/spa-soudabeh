using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace Academy.Gateways.RestApi.Middlewares
{
    public static class RequestLoggingExtension
    {
        public static void UseRequestLogging(this IApplicationBuilder app)
        {
            app.UseMiddleware<RequestLoggingMiddleware>();
        }
    }
}
