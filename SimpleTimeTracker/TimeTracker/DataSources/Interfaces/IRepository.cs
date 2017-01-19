using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.DataTypes.BaseClasses;
using TimeTracker.DataTypes.Interfaces;

namespace TimeTracker.DataSources.Interfaces
{
    interface IRepository<T> where T : IEntity
    {
        T GetById(Int64 id);

        void Create(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}
