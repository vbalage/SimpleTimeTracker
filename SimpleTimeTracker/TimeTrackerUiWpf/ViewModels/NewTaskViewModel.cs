using System;
using TimeTracker.Core.DataTypes;
using TimeTracker.Interface.DataTypes;
using TimeTrackerUiWpf.Interfaces;

namespace TimeTrackerUiWpf.ViewModels
{
    public class NewTaskViewModel : ITabViewModel
    {
        public string Header { get; set; }
        public ITask Task { get; set; }

        public NewTaskViewModel(TimeTrackerContext dbContext)
        {
            if(dbContext == null)
                throw new ArgumentNullException(nameof(dbContext));

            Task = new Task();
        }
    }
}
