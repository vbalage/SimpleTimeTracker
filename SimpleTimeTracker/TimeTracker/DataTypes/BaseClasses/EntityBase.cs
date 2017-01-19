using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.DataTypes.Interfaces;

namespace TimeTracker.DataTypes.BaseClasses
{
    public abstract class EntityBase : IEntity
    {
        public Int64 Id { get; protected set; }
    }
}
