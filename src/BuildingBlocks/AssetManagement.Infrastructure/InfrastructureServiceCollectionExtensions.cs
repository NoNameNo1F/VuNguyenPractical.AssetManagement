using Microsoft.Extensions.Caching.Hybrid;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection;

public static class InfrastructureServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var settings = new DistributedCacheOptions();
        configuration.Bind(settings);

        services.AddHybridCache(options =>
        {
            options.DefaultEntryOptions = new HybridCacheEntryOptions
            {
                Expiration = TimeSpan.FromMinutes(5)
            };
        });

        services.AddStackExchangeRedisCache(options =>
        {
            options.Configuration = settings.Redis.Configuration;
            options.InstanceName = settings.Redis.InstanceName;
        });
        
        return services;
    }
}