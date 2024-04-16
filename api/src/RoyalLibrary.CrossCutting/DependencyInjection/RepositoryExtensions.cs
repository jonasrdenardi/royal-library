using Microsoft.Extensions.DependencyInjection;
using RoyalLibrary.Domain.Repository;
using RoyalLibrary.Infra.Repository.SqlServer;

namespace RoyalLibrary.CrossCutting.DependencyInjection
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IBookRepository, BookRepository>();

            return services;
        }
    }
}
