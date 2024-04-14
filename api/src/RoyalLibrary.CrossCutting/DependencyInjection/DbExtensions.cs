using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RoyalLibrary.Infra.Context;

namespace RoyalLibrary.CrossCutting.DependencyInjection
{
    public static class DbExtensions
    {
        public static IServiceCollection AddSqlServer(this IServiceCollection services, IConfiguration configuration)
        {
            var sqlConnection = configuration.GetConnectionString("SqlConnection");
            services.AddDbContextPool<RoyalLibraryContext>(o => o.UseSqlServer(sqlConnection));

            return services;
        }
    }
}
