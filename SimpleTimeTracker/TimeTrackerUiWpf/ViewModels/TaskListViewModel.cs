using System;
using System.Collections.ObjectModel;
using TimeTracker.Interface.DataTypes;
using TimeTrackerUiWpf.Interfaces;
using TimeTrackerUiWpf.Models;

namespace TimeTrackerUiWpf.ViewModels
{
    public class TaskListViewModel : NotifyBase, ITabViewModel
    {
        private ObservableCollection<ITask> _taskList;
        public string Header { get; set; } = "Task List";

        public ObservableCollection<ITask> TaskList
        {
            get
            {
                return _taskList;
            }
            set
            {
                _taskList = value;
                OnPropertyChanged(nameof(TaskList));
            }
        }

        public TaskListViewModel(TimeTrackerContext dbContext)
        {
            if (dbContext == null)
                throw new ArgumentNullException(nameof(dbContext));

            TaskList = new ObservableCollection<ITask>(dbContext.Tasks.Select(t=>t));        
        }
    }
}
