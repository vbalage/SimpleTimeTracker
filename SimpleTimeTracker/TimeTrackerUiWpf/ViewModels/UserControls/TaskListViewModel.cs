using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TimeTracker.Core.Utils;
using TimeTracker.Interface.DataTypes;
using TimeTracker.Interface.Timer;
using TimeTrackerUiWpf.BaseClasses;
using TimeTrackerUiWpf.Interfaces;

namespace TimeTrackerUiWpf.ViewModels.UserControls
{
    public class TaskListViewModel : NotifyBase, ITabViewModel
    {
        public string Header { get; set; } = "Task List";

        private ObservableCollection<TaskViewModel> _tasks;
        public ObservableCollection<TaskViewModel> Tasks
        {
            get { return _tasks; }
            set
            {
                _tasks = value;
                OnPropertyChanged("Tasks");
            }
        }

        private TaskViewModel _selectedTask;
        public TaskViewModel SelectedTask
        {
            get { return _selectedTask; }
            set
            {
                _selectedTask = value;
                _sessions.Clear();

                if (_selectedTask != null)
                {
                    foreach (var session in _selectedTask.Sessions)
                    {
                        _sessions.Add(SessionViewModel.Create(session));
                    }
                }
                OnPropertyChanged("SelectedTask");
            }
        }

        private ObservableCollection<SessionViewModel> _sessions;
        public ObservableCollection<SessionViewModel> Sessions
        {
            get { return _sessions; }
            set
            {
                _sessions = value;
                OnPropertyChanged("Sessions");
            }
        }

        private SessionViewModel _selectedSession;
        public SessionViewModel SelectedSession
        {
            get { return _selectedSession; }
            set
            {
                _selectedSession = value;
                OnPropertyChanged("SelectedSession");
            }
        }

        private readonly ITimerFactory _timerFactory;

        public TaskListViewModel(ITimerFactory timerFactory)
        {
            if(timerFactory == null)
                throw new ArgumentNullException(nameof(timerFactory));

            _tasks = new ObservableCollection<TaskViewModel>();
            _sessions = new ObservableCollection<SessionViewModel>();

            Tasks = new ObservableCollection<TaskViewModel>();
            for (int i = 0; i < 3; i++)
            {
                var task = new TaskViewModel() { Id = i, Name = "Task " + i };
                for (int j = 0; j < 5; j++)
                {
                    var session = new SessionViewModel(timerFactory)
                    {
                        Description = "Session " + j,
                        StartTime = DateTime.Now,
                        EndTime = DateTime.Now,
                        Id = j,
                        ParentTask = task
                    };
                    task.Sessions.Add(session);
                }
                Tasks.Add(task);
            }
        }
    }
}
