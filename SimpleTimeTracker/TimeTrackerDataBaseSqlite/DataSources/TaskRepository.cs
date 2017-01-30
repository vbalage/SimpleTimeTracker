using System;
using System.Data.Entity;
using TimeTracker.Interface.DataTypes;

namespace TimeTrackerDataBaseSqlite.DataSources
{
    public class TaskRepository : EntityFrameworkRepositoryBase<ITask, Int32>
    {
		public TaskRepository(DbContext dbContext) : base(dbContext)
		{

		}
    }
}
