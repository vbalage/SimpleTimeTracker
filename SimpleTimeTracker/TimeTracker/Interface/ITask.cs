using System.Collections.Generic;

namespace TimeTracker.Interface
{
    public interface ITask
    {
        string Name { get; set; }
        IList<ISession> Sessions { get; set; }
    }
}