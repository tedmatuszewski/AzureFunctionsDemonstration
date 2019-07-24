using System.Collections.Generic;
using Test.Domain.Repositories.Database;

namespace Test.Data.Entity.Repositories
{
    public class WidgetRepository : IWidgetRepository
    {
        public List<int> Get()
        {
            return new List<int>();
        }
    }
}
