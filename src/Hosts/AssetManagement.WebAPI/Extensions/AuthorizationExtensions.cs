using Microsoft.AspNetCore.Authorization;

namespace AssetManagement.WebAPI.Extensions;

internal static class AuthorizationExtensions
{
    internal static IServiceCollection AddAuthorizationExtension(this IServiceCollection services)
    {
        services.AddAuthorization(options =>
        {
            options.DefaultPolicy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
            
            options.AddPolicy("AdminOnly", policy =>
                policy.RequireRole("Admin"));
        });

        return services;
    }
}