using System;
using System.Collections.Generic;
using TimeTracker.Interface.DataTypes;

namespace TimeTracker.Interface.DataSources
{
    public interface IRepository<TEntity, TKey> where TEntity : class
    {
        TEntity GetById(TKey id);

		IEnumerable<TEntity> GetAll();

        void Create(TEntity entity);

        void Delete(TEntity entity);

        void Update(TEntity entity);
    }
}
