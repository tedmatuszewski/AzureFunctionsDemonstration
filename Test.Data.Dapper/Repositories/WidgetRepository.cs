using System.Collections.Generic;
using Test.Domain.Entities.Database;
using Test.Domain.Repositories.Database;

namespace Test.Data.Dapper.Repositories
{
    internal class WidgetRepository : IWidgetRepository
    {
        internal WidgetRepository()
        {
        }

        public IEnumerable<Weather> Get()
        {
            var result = new List<Weather>();

            return result;
        }
    }
}
