using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Interface.DataSources;
using TimeTracker.Interface.DataTypes;

namespace TimeTrackerDataBaseSqlite.DataSources
{
    public class SqLiteDbContext : IDbContext
    {
        private readonly SqLiteContext _dbContext;

        public SqLiteDbContext()
        {
            _dbContext = new SqLiteContext();
        }

        public IRepository<ISession> Sessions => new SessionRepository(_dbContext.Sessions);

        public IRepository<ITask> Tasks => new TaskRepository(_dbContext.Tasks);
    }
}
