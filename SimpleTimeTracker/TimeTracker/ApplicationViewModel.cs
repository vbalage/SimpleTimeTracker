using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Model;

namespace TimeTracker
{
    internal class ApplicationViewModel
    {
        public ObservableCollection<ITask> TaskList { get; set; }

        public ApplicationViewModel()
        {
            TaskList = new ObservableCollection<ITask>();
        }
    }
}
