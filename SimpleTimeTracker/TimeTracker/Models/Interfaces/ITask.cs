using System.Collections.Generic;
using TimeTracker.Interface;

namespace TimeTracker.Models.Interfaces
{
    public interface ITask
    {
        string Name { get; set; }
        IList<ISession> Sessions { get; set; }
    }
}