using System;
using System.ComponentModel.DataAnnotations;
using TimeTracker.Interface.DataTypes;

namespace TimeTracker.Interface.DataTypes
{
    public interface IEntity<TKey>
    {
		[Key]
        TKey Id { get; set; }
    }
}