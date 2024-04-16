using Microsoft.Extensions.DependencyInjection;
using RoyalLibrary.Domain.Cache;
using RoyalLibrary.Domain.Notification;
using RoyalLibrary.Domain.Repository;
using RoyalLibrary.Infra.Cache;
using RoyalLibrary.Infra.Notification;
using RoyalLibrary.Infra.Repository.SqlServer;

namespace RoyalLibrary.CrossCutting.DependencyInjection
{
    public static class CacheExtensions
    {
        public static IServiceCollection AddCaches(this IServiceCollection services)
        {
            services.AddTransient<ICache, RedisCache>();

            return services;
        }
    }
}
