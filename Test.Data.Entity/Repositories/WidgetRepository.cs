using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Test.Domain.Entities.Database;
using Test.Domain.Repositories.Database;

namespace Test.Data.Entity.Repositories
{
    internal class WidgetRepository : BaseRepository<Weather>, IWidgetRepository
    {
        internal WidgetRepository(TestDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Weather> Get()
        {
            var result = this._context.Weather.AsNoTracking().Where(x => x.Deleted == false).AsEnumerable();

            return result;
        }
    }
}
