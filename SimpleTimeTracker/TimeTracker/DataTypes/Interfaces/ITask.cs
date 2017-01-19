using System.Collections.Generic;

namespace TimeTracker.DataTypes.Interfaces
{
    public interface ITask : IEntity
    {
        string Name { get; set; }
        IList<ISession> Sessions { get; set; }
    }
}