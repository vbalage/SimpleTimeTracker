using System.Collections.ObjectModel;

namespace TimeTracker.Interface
{
    public interface IDataModel
    {
        ObservableCollection<ITask> TaskList { get; set; }
    }
}