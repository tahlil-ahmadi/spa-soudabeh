using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Application;
using Academy.Config;
using Academy.Gateways.RestApi.Configs;
using Academy.Gateways.RestApi.Middlewares;
using Autofac;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Academy.Gateways.RestApi
{
    public class Startup
    {
        private AcademyConfig academyConfig;
        public Startup(IConfiguration configuration)
        {
            academyConfig = configuration.Get<AcademyConfig>();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc(options => options.Filters.Add(new AuthorizeFilter()));
            services.AddMvc();
            services.AddCors();
            services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
                .AddIdentityServerAuthentication(options =>
                {
                    options.Authority = "http://localhost:5000";
                    options.ApiName = "soudabeh-api";
                    options.RequireHttpsMetadata = false;
                });
        }
        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new AcademyModule(academyConfig.ConnectionStrings.MainDbConnection));
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRequestLogging();
            app.UseAuthentication();
            app.UseCors(builder => builder.Apply(academyConfig.CorsOptions));
            app.UseMvcWithDefaultRoute();
        }
    }
}
