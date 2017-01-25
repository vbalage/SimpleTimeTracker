using System;
using TimeTracker.Interface.DataTypes;

namespace TimeTracker.Core.DataTypes
{
    public class Session : ISession
    {
        public long Id { get; set; }

        public string Description { get; set; }

        public DateTime EndTime { get; set; }

        public DateTime StartTime { get; set; }

        public ITask ParentTask { get; set; }
    }
}
