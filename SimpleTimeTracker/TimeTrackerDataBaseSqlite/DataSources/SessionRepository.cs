using System;
using TimeTracker.Interface.DataSources;
using TimeTracker.Interface.DataTypes;

namespace TimeTrackerDataBaseSqlite.DataSources
{
    public class SessionRepository : GenericRepository<ISession>
    {
        public override void Create(ISession entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(ISession entity)
        {
            throw new NotImplementedException();
        }

        public override ISession GetById(long id)
        {
            throw new NotImplementedException();
        }

        public override void Update(ISession entity)
        {
            throw new NotImplementedException();
        }
    }
}
