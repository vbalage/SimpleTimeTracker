using System;

namespace TimeTracker.Interface.DataTypes
{
    public interface ISession : IEntity
    {
        ITask ParentTask { get; set; }

        string Description { get; set; }
               
        DateTime EndTime { get; set; }

        DateTime StartTime { get; set; }
    }
}