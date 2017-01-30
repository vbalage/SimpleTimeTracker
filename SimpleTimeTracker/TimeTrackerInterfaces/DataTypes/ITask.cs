using System;
using System.Collections.Generic;

namespace TimeTracker.Interface.DataTypes
{
    public interface ITask : IEntity<Int32>
    {
        string Name { get; set; }

        ICollection<ISession> Sessions { get; set; }
    }
}