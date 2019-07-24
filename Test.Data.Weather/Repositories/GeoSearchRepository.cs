using System.Net.Http;
using System.Threading.Tasks;
using Test.Domain.Repositories.Weather;

namespace Test.Data.Weather.Repositories
{
    public class GeoSearchRepository : IGeoSearchRepository
    {
        public async Task<string> Get(string city, string state, string country, double? days)
        {
            var http = new HttpClient();
            var client = new WeatherService.Client(http);
            var result = await client.Geosearch2Async(city, state, country, days, WeatherService.Units12.S, WeatherService.Lang12.Es, null, null);

            return result.State_code;
        }
    }
}
