using Microsoft.Extensions.DependencyInjection;
using Test.Data.Entity.Repositories;
using Test.Domain.Repositories.Database;

namespace Test.Data.Entity
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEntityServices(this IServiceCollection services)
        {
            services.AddScoped<IWidgetRepository, WidgetRepository>();

            return services;
        }
    }
}
