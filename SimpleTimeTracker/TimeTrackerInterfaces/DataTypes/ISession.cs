using System;

namespace TimeTracker.Interface.DataTypes
{
    public interface ISession : IEntity<Int32>
    {
        ITask ParentTask { get; set; }

        string Description { get; set; }
               
        DateTime EndTime { get; set; }

        DateTime StartTime { get; set; }
    }
}