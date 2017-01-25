using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Interface.DataTypes;

namespace TimeTrackerUiWpf.ViewModels
{
    public class TaskViewModel : ITask
    {
        public TaskViewModel()
        {
            Sessions = new List<ISession>();
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public ICollection<ISession> Sessions { get; set; }
    }
}
