using System;
using TimeTracker.Interface.DataSources;
using TimeTracker.Interface.DataTypes;

namespace TimeTrackerDataBaseSqlite.DataSources
{
    public abstract class GenericRepository<T> : IRepository<T> where T : IEntity
    {
        public abstract void Create(T entity);

        public abstract void Delete(T entity);

        public abstract T GetById(long id);

        public abstract void Update(T entity);
    }
}
