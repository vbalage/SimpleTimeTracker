using System;

namespace TimeTracker.Interface.DataTypes
{
    public interface ISession : IEntity
    {
        long TaskId { get; set; }

        string Description { get; set; }
               
        DateTime EndTime { get; set; }

        DateTime StartTime { get; set; }
    }
}