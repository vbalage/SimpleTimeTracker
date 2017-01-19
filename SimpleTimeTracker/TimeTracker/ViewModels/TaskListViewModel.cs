using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using TimeTracker.DataSources;
using TimeTracker.DataTypes;
using TimeTracker.DataTypes.Interfaces;
using TimeTracker.Models;
using TimeTracker.ViewModels.Interfaces;

namespace TimeTracker.ViewModels
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
