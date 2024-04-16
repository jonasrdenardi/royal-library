using Microsoft.Extensions.DependencyInjection;
using RoyalLibrary.Domain.Notification;
using RoyalLibrary.Domain.Repository;
using RoyalLibrary.Infra.Notification;
using RoyalLibrary.Infra.Repository.SqlServer;

namespace RoyalLibrary.CrossCutting.DependencyInjection
{
    public static class NotificationExtensions
    {
        public static IServiceCollection AddNotifications(this IServiceCollection services)
        {
            services.AddTransient<INotification, SnsNotification>();

            return services;
        }
    }
}
