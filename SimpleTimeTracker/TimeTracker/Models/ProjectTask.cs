using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Interface;
using TimeTracker.Models.Interfaces;

namespace TimeTracker.Models
{
    internal class ProjectTask : NotifyBase, ITask
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));                
            }
        }

        public IList<ISession> Sessions { get; set; }

        public ProjectTask()
        {
            Name = string.Empty;
            Sessions = new List<ISession>();
        }
    }
}
