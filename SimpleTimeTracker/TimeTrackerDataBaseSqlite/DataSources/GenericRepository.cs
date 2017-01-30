using System;
using System.Collections.Generic;
using System.Data.Entity;
using TimeTracker.Interface.DataSources;
using TimeTracker.Interface.DataTypes;

namespace TimeTrackerDataBaseSqlite.DataSources
{
    public abstract class GenericRepository<T> : IRepository<T, Int32> where T : class, IEntity
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
