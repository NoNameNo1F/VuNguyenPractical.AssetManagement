using System.Text;
using AssetManagement.WebAPI.ConfigurationOptions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace AssetManagement.WebAPI.Extensions;

internal static class AuthenticationExtensions
{
    internal static IServiceCollection AddAuthenticationExtension(this IServiceCollection services, Action<JwtOptions> configureOptions)
    {
        var jwtOptions = new JwtOptions();
        configureOptions(jwtOptions);
        services.Configure<JwtOptions>(configureOptions);

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            // use OIDC 
            // options.Authority = "https://localhost:8080/";
            options.RequireHttpsMetadata = false;
            options.IncludeErrorDetails = true;
            // options.SaveToken = true;
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = jwtOptions.Issuer,
                ValidateAudience = true,
                ValidAudience = jwtOptions.Audience,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.Key)),
                ValidateLifetime = true,
                ClockSkew = TimeSpan.FromSeconds(5)
            };

            options.Events = new JwtBearerEvents
            {
                OnMessageReceived = context =>
                {
                    var accessToken = context.Request.Cookies["access"];
                    if (!string.IsNullOrEmpty(accessToken))
                    {
                        context.Token = accessToken;
                    }

                    return Task.CompletedTask;
                },

                OnChallenge = context =>
                {
                    context.HandleResponse();
                    throw new UnauthorizedAccessException();
                },

                OnForbidden = context =>
                {
                    throw new UnauthorizedAccessException("Permission denied!");
                }
            };
        });

        return services;
    }
}