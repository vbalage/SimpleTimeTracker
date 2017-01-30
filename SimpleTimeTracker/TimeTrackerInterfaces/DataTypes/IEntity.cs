using System;
using TimeTracker.Interface.DataTypes;

namespace TimeTracker.Interface.DataTypes
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}