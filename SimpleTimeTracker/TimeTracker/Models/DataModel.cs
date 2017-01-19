using System.Collections.ObjectModel;
using TimeTracker.DataTypes.Interfaces;

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
