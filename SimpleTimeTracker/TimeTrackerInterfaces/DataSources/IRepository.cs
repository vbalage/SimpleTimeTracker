using System;
using TimeTracker.Interface.DataTypes;

namespace TimeTracker.Interface.DataSources
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        TEntity GetById(long id);

        void Add(TEntity entity);

        void Delete(TEntity entity);

        void Update(TEntity entity);
    }
}
