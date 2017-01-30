using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TimeTracker.Interface.DataTypes;

namespace TimeTracker.Core.DataTypes
{
	[Table("Tasks")]
    public class Task : ITask
    {		
        public string Name { get; set; }       

        public Int32 Id { get; set; }

        public ICollection<ISession> Sessions { get; set; }
    }
}
