using System.Collections.Generic;
using System.Linq;
using Test.Domain.App;
using Test.Domain.Converters;
using Test.DTO.Types;

namespace Test.Domain.Services
{
    public partial class TestService : ITestService
    {
        private IDatabaseContext _db;

        private IWeatherContext _weather;

        public TestService(IDatabaseContext db, IWeatherContext intelex)
        {
            this._db = db;
            this._weather = intelex;
        }

        public List<WeatherDTO> SendAllWidgetEmails()
        {
            var widgets1 = this._db.widgetRepository.Get().Select(w => w.Convert()).ToList();
            var widgets2 = this._weather.geoSearchRepository.Get("Linwood", "MI", "USA", 4);

            return widgets1;
        }
    }
}
