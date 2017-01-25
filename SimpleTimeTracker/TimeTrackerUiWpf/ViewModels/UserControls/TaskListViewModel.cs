using System.Collections.ObjectModel;
using TimeTrackerUiWpf.BaseClasses;
using TimeTrackerUiWpf.Interfaces;

namespace TimeTrackerUiWpf.ViewModels.UserControls
{
    public class TaskListViewModel : NotifyBase, ITabViewModel
    {
        private ObservableCollection<TaskViewModel> _taskList;
        public string Header { get; set; } = "Task List";

        public ObservableCollection<TaskViewModel> TaskList
        {
            get { return _taskList; }
            set
            {
                _taskList = value;
                OnPropertyChanged("TaskList");
            }
        }

        public TaskListViewModel()
        {

            TaskList = new ObservableCollection<TaskViewModel>()
            {
                new TaskViewModel() {Name = "task1"},
                new TaskViewModel() {Name = "task2"}
            };
        }
    }
}
