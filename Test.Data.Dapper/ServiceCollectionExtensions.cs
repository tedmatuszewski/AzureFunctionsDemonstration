using Microsoft.Extensions.DependencyInjection;
using Test.Data.Dapper.Repositories;
using Test.Domain.Repositories.Database;

namespace Test.Data.Dapper
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDapperServices(this IServiceCollection services)
        {
            services.AddScoped<IWidgetRepository, WidgetRepository>();

            return services;
        }
    }
}
