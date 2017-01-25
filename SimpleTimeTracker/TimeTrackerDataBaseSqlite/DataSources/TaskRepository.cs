using System;
using TimeTracker.Interface.DataSources;
using TimeTracker.Interface.DataTypes;

namespace TimeTrackerDataBaseSqlite.DataSources
{
    public class TaskRepository : GenericRepository<ITask>
    {
        private SqLiteContext _dbContext;

        public TaskRepository(SqLiteContext dbContext)
        {
            if(dbContext == null)
                throw new ArgumentNullException(nameof(dbContext));

            _dbContext = dbContext;
        }

        public override void Create(ITask entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(ITask entity)
        {
            throw new NotImplementedException();
        }

        public override ITask GetById(long id)
        {
            throw new NotImplementedException();
        }

        public override void Update(ITask entity)
        {
            throw new NotImplementedException();
        }
    }
}
