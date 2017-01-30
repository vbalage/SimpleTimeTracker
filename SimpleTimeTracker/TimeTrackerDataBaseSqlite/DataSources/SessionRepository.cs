using System;
using System.Data.Entity;
using TimeTracker.Interface.DataTypes;

namespace TimeTrackerDataBaseSqlite.DataSources
{
    public class SessionRepository : EntityFrameworkRepositoryBase<ISession, Int32>
	{
		public SessionRepository(DbContext dbContext) : base(dbContext)
		{

		}
	}
}
