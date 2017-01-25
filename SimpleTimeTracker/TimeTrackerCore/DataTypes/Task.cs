using System;
using System.Collections.Generic;
using TimeTracker.Interface.DataTypes;

namespace TimeTracker.Core.DataTypes
{
    public class Task : ITask
    {
        public string Name { get; set; }       

        public long Id { get; set; }

        public ICollection<ISession> Sessions { get; set; }
    }
}
