using Microsoft.Extensions.DependencyInjection;
using RoyalLibrary.Domain.Handler;
using RoyalLibrary.Domain.Notification;
using RoyalLibrary.Domain.Repository;
using RoyalLibrary.Infra.Notification;
using RoyalLibrary.Infra.Repository.SqlServer;
using RoyalLibrary.Sevice.Handler;

namespace RoyalLibrary.CrossCutting.DependencyInjection
{
    public static class HandlerExtensions
    {
        public static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            services.AddTransient<IBookHandler, BookHandler>();

            return services;
        }
    }
}
