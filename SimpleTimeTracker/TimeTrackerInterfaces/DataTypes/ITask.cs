using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeTracker.Interface.DataTypes
{
    public interface ITask : IEntity<Int32>
    {
		[Column("Name")]
        string Name { get; set; }

        ICollection<ISession> Sessions { get; set; }
    }
}