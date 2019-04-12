using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace Academy.Gateways.RestApi.Configs
{
    public static class CorsPolicyBuilderExtensions
    {
        public static void Apply(this CorsPolicyBuilder builder, CorsOptions options)
        {
            builder.WithHeaders(options.AllowedHeaders)
                .WithMethods(options.AllowedMethods)
                .WithOrigins(options.AllowedHosts);
        }
    }
}
