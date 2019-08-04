using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Test.Data.Entity;
using Test.Domain;
using Test.Data.Weather;
using Test.Data.Dapper;

[assembly: FunctionsStartup(typeof(Test.FN.Job1.Startup))]

namespace Test.FN.Job1
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddDomainServices();
            builder.Services.AddEntityServices();
            //builder.Services.AddDapperServices();
            builder.Services.AddWeatherServices();
        }
    }
}
