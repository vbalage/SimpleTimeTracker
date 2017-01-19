using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.DataSources.Interfaces;
using TimeTracker.DataTypes.BaseClasses;
using TimeTracker.DataTypes.Interfaces;

namespace TimeTracker.DataSources
{
    public class Repository<T> : IRepository<T> where T : IEntity
    {
        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
