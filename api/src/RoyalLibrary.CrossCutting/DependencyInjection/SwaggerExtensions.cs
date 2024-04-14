using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;

namespace RoyalLibrary.CrossCutting.DependencyInjection
{
    public static class SwaggerExtensions
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services, string assemblyName)
        {
            services.AddSwaggerGen(c =>
            {
                c.CustomSchemaIds(type => type.ToString());

                c.SwaggerDoc("v1", new OpenApiInfo { Title = "RoyalLibrary.Api", Version = "v1" });

                var xmlFile = $"{assemblyName}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerApp(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RoyalLibrary.Api v1"));

            return app;
        }
    }
}
