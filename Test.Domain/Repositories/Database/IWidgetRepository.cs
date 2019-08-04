using System.Collections.Generic;

namespace Test.Domain.Repositories.Database
{
    public interface IWidgetRepository
    {
        IEnumerable<Test.Domain.Entities.Database.Weather> Get();
    }
}
