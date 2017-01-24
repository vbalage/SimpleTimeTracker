using System;
using TimeTracker.Interface.DataSources;
using TimeTracker.Interface.DataTypes;

namespace TimeTracker.Core.DataSources
{
    internal class SessionRepository : IRepository<ISession>
    {
        public void Create(ISession entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ISession entity)
        {
            throw new NotImplementedException();
        }

        public ISession GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(ISession entity)
        {
            throw new NotImplementedException();
        }
    }
}
