using System;
using System.Data.Entity;
using System.Threading;
using TimeTracker.Interface.DataSources;
using TimeTracker.Interface.DataTypes;

namespace TimeTrackerDataBaseSqlite.DataSources
{
    public class SessionRepository : GenericRepository<ISession>
    {
        public SessionRepository(DbSet<ISession> dbSet) : base(dbSet)
        {
        }

        public override void Add(ISession entity)
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
