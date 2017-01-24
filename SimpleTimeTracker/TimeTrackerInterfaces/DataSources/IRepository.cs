using System;
using TimeTracker.Interface.DataTypes;

namespace TimeTracker.Interface.DataSources
{
    public interface IRepository<T> where T : IEntity
    {
        T GetById(long id);

        void Create(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}
