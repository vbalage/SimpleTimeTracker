using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Interface;
using TimeTracker.Models.Interfaces;

namespace TimeTracker.Models
{
    internal class DataModel : IDataModel
    {
        public ObservableCollection<ITask> TaskList { get; set; }
        
        public DataModel()
        {
            
        }
    }
}
