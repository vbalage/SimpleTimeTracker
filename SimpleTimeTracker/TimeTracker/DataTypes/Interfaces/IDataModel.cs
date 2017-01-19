using System.Collections.ObjectModel;

namespace TimeTracker.DataTypes.Interfaces
{
    public interface IDataModel
    {
        ObservableCollection<ITask> TaskList { get; set; }
        
    }
}