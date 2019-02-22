using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Application;
using Academy.Config;
using Autofac;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace Academy.Gateways.RestApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.Filters.Add(new AuthorizeFilter()));
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
            builder.RegisterModule(new AcademyModule());
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseCors(builder =>
            {
                //TODO: don't try this at home
                builder.AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowAnyOrigin();
            });

            app.UseMvcWithDefaultRoute();
        }
    }
}
