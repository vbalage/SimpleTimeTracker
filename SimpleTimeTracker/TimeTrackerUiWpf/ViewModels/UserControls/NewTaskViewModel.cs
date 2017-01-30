using TimeTrackerUiWpf.BaseClasses;
using TimeTrackerUiWpf.Interfaces;

namespace TimeTrackerUiWpf.ViewModels.UserControls
{
    internal class NewTaskViewModel : ModelBase, ITabViewModel
    {
        private TaskViewModel _task;
        public string Header { get; set; } = "New task";

        public TaskViewModel Task
        {
            get { return _task; }
            set
            {
                _task = value;
                OnPropertyChanged("Task");
            }
        }

        public NewTaskViewModel()
        {
            Task = new TaskViewModel() { Name = "test task"};
        }
    }
}
