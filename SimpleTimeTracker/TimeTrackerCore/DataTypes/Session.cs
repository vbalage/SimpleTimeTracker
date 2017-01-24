using System;
using TimeTracker.Interface.DataTypes;
using TimeTracker.Utils.Interfaces;

namespace TimeTracker.Core.DataTypes
{
    public class Session : ISession
    {
        public long Id { get; set; }
        public long TaskId { get; set; }
        public string Description { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime StartTime { get; set; }
    }
}
