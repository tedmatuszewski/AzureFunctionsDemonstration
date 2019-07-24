using Microsoft.Extensions.DependencyInjection;
using Test.Domain.Services;

namespace Test.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<ITestService, TestService>();

            return services;
        }
    }
}
