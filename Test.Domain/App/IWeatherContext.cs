using Test.Domain.Repositories.Weather;

namespace Test.Domain.App
{
    public interface IWeatherContext
    {
        IGeoSearchRepository geoSearchRepository { get; }
    }
}
