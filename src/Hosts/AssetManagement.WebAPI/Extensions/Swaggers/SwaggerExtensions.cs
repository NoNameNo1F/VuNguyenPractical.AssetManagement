using Asp.Versioning.ApiExplorer;
using Microsoft.OpenApi.Models;

namespace AssetManagement.WebAPI.Extensions.Swaggers;

internal static class SwaggerExtensions
{
    internal static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "AssetManagement WebAPI",
                Version = "v1",
                Description = "AssetManagement API Modulith .NET Backend.",
                Contact = new OpenApiContact
                {
                    Name = "AssetManagement Support",
                    Email = "vunguyencaonam@gmail.com"
                }
            });
            options.CustomSchemaIds(t => t.ToString());
            
            options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Description =
                    "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey
            });

            options.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        },
                        Scheme = "oauth2",
                        Name = "Bearer",
                        In = ParameterLocation.Header
                    },
                    new List<string>()
                }
            });
            
            options.OperationFilter<SwaggerResponseFilter>();
        });

        return services;
    }

    internal static WebApplication UseSwaggerDocumentation(this WebApplication app)
    {
        app.UseSwagger();

        var apiVersionDescriptionProvider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

        app.UseSwaggerUI(options =>
        {
            foreach (var description in apiVersionDescriptionProvider.ApiVersionDescriptions)
            {
                options.SwaggerEndpoint(
                    $"/swagger/{description.GroupName}/swagger.json",
                    description.GroupName.ToUpperInvariant());
            }
        });

        return app;
    }   
}