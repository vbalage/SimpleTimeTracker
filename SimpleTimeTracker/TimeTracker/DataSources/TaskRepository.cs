using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.DataSources.Interfaces;
using TimeTracker.DataTypes.Interfaces;

namespace TimeTracker.DataSources
{
    internal class TaskRepository : IRepository<ITask>
    {
        public void Create(ITask entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ITask entity)
        {
            throw new NotImplementedException();
        }

        public ITask GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(ITask entity)
        {
            throw new NotImplementedException();
        }
    }
}
