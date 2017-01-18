using System.Collections.ObjectModel;
using TimeTracker.Models.Interfaces;

namespace TimeTracker.Interface
{
    public interface IDataModel
    {
        ObservableCollection<ITask> TaskList { get; set; }
        
    }
}