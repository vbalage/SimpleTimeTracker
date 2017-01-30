using System;
using TimeTracker.Interface.DataSources;
using TimeTracker.Interface.DataTypes;

namespace TimeTrackerDataBaseSqlite.DataSources
{
    public class SqLiteDbContext : IDbContext
    {
        private readonly TimeTrackerContextSqLite _dbContext;

        public SqLiteDbContext()
        {
            _dbContext = new TimeTrackerContextSqLite();
        }

        public IRepository<ISession, Int32> Sessions => new SessionRepository(_dbContext);
        public IRepository<ITask, Int32> Tasks => new TaskRepository(_dbContext);
    }
}
