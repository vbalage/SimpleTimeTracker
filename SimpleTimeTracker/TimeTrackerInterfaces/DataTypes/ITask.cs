using System.Collections.Generic;

namespace TimeTracker.Interface.DataTypes
{
    public interface ITask : IEntity
    {
        string Name { get; set; }

        ICollection<ISession> Sessions { get; set; }
    }
}