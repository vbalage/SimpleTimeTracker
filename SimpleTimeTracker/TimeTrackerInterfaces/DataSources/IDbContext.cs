using TimeTracker.Interface.DataTypes;

namespace TimeTracker.Interface.DataSources
{
    public interface IDbContext
    {
        IRepository<ITask> Tasks { get; }
        IRepository<ISession> Sessions { get; }
    }
}
