using System.Collections.Generic;

namespace TimeTracker.Model
{
    internal interface ITask
    {
        string Name { get; set; }
        IList<ISession> Sessions { get; set; }
    }
}