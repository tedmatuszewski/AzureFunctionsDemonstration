using Test.Domain.App;

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

        public bool SendAllWidgetEmails()
        {
            var widgets1 = this._db.widgetRepository.Get();
            var widgets2 = this._weather.geoSearchRepository.Get("Linwood", "MI", "USA", 4);

            return false;
        }
    }
}
