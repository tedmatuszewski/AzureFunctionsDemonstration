using Test.Data.Weather.Repositories;
using Test.Domain.App;
using Test.Domain.Repositories.Weather;

namespace Test.Data.Entity
{
    public class WeatherContext : IWeatherContext
    {
        public WeatherContext()
        {
            this.geoSearchRepository = new GeoSearchRepository();
        }

        public IGeoSearchRepository geoSearchRepository { get; }
    }
}
