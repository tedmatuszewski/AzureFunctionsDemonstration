using Microsoft.Extensions.DependencyInjection;
using Test.Data.Weather.Repositories;
using Test.Domain.Repositories.Weather;

namespace Test.Data.Weather
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWeatherServices(this IServiceCollection services)
        {
            services.AddScoped<IGeoSearchRepository, GeoSearchRepository>();

            return services;
        }
    }
}
