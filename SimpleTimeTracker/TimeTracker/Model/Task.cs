using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Interface;

namespace TimeTracker.Model
{
    internal class Task : ITask
    {
        public string Name { get; set; }
        public IList<ISession> Sessions { get; set; }

        public Task()
        {
            Name = string.Empty;
            Sessions = new List<ISession>();
        }
    }
}
