using System;
using System.Data.Entity;
using System.Linq;
using TimeTracker.Interface.DataSources;
using TimeTracker.Interface.DataTypes;

namespace TimeTrackerDataBaseSqlite.DataSources
{
    public class TaskRepository : GenericRepository<ITask>
    {
        public TaskRepository(DbSet<ITask> dbSet) : base(dbSet)
        {
        }

        public override void Add(ITask entity)
        {
            DbSet.Add(entity);
        }

        public override void Delete(ITask entity)
        {
            DbSet.Remove(entity);
        }

        public override ITask GetById(long id)
        {
            return DbSet.Find(id);
        }

        public override void Update(ITask entity)
        {
            throw new NotImplementedException();
        }
    }
}
