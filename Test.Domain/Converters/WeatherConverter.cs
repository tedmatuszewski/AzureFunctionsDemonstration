using Test.Domain.Entities.Database;
using Test.DTO.Types;

namespace Test.Domain.Converters
{
    public static class WeatherConverter
    {
        public static Weather Convert(this WeatherDTO dto)
        {
            var result = new Weather();

            return result;
        }

        public static WeatherDTO Convert(this Weather entity)
        {
            var result = new WeatherDTO();

            return result;
        }
    }
}
