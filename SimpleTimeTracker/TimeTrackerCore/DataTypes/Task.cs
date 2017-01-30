using System;
using System.Collections.Generic;
using TimeTracker.Interface.DataTypes;

namespace TimeTracker.Core.DataTypes
{
    public class Task : ITask
    {
        public string Name { get; set; }       

        public Int32 Id { get; set; }

        public ICollection<ISession> Sessions { get; set; }
    }
}
