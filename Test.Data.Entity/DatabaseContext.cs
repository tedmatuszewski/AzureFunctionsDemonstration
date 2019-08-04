using System;
using Test.Data.Entity.Repositories;
using Test.Domain.App;
using Test.Domain.Repositories.Database;

namespace Test.Data.Entity
{
    public class DatabaseContext : IDisposable, IDatabaseContext
    {
        private TestDbContext context;

        public DatabaseContext()
        {
            this.context = new TestDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<TestDbContext>());
            this.widgetRepository = new WidgetRepository(context);
        }

        public IWidgetRepository widgetRepository { get; }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
