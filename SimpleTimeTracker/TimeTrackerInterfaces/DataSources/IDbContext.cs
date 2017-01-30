using System;
using TimeTracker.Interface.DataTypes;

namespace TimeTracker.Interface.DataSources
{
    public interface IDbContext
    {
        IRepository<ITask, Int32> Tasks { get; }
        IRepository<ISession, Int32> Sessions { get; }
    }
}
