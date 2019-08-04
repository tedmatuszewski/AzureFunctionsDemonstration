using Microsoft.EntityFrameworkCore;
using System;

namespace Test.Data.Entity.Repositories
{
    internal class BaseRepository<T> where T : class, Domain.Entities.Database.IEntity
    {
        protected TestDbContext _context;
        protected DateTime now = DateTime.Now;

        public BaseRepository(TestDbContext _dbContext)
        {
            this._context = _dbContext;
        }

        public T Create(T entity, string netid)
        {
            var domain = this._context.Add<T>(entity);

            domain.Entity.DateAdded = now;
            domain.Entity.AddedBy = netid;
            domain.Entity.DateUpdated = now;
            domain.Entity.UpdatedBy = netid;
            domain.Entity.Deleted = false;
            domain.State = EntityState.Added;

            return domain.Entity;
        }

        public T Delete(int id, string netid)
        {
            var delete = System.Activator.CreateInstance<T>();

            delete.Id = id;
            delete.Deleted = true;
            delete.DateUpdated = now;
            delete.UpdatedBy = netid;

            var entity = _context.Attach(delete);

            entity.Property(x => x.Deleted).IsModified = true;
            entity.Property(x => x.UpdatedBy).IsModified = true;
            entity.Property(x => x.DateUpdated).IsModified = true;

            return entity.Entity;
        }

        public T Update(T entity, string netid)
        {
            var domain = this._context.Attach(entity);

            domain.Entity.DateUpdated = now;
            domain.Entity.UpdatedBy = netid;
            domain.Entity.Deleted = false;
            domain.State = EntityState.Modified;
            domain.Property(e => e.DateAdded).IsModified = false;
            domain.Property(e => e.AddedBy).IsModified = false;

            return domain.Entity;
        }
    }
}
