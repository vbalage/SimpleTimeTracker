using System;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using TimeTracker.Interface.DataSources;
using TimeTracker.Interface.DataTypes;

namespace TimeTrackerDataBaseSqlite.DataSources
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class, IEntity
    {
        protected DbSet<T> DbSet;

        protected GenericRepository(DbSet<T> dbSet)
        {
            if(dbSet == null)
                throw new ArgumentNullException("dbSet");

            DbSet = dbSet;
        }

        public abstract void Add(T entity);

        public abstract void Delete(T entity);

        public abstract T GetById(long id);

        public abstract void Update(T entity);
    }
}
