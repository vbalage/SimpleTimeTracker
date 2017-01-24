using System;
using TimeTracker.Interface.DataSources;
using TimeTracker.Interface.DataTypes;

namespace TimeTracker.Core.DataSources
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
