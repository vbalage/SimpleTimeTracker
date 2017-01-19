using System;
using System.Data.Entity;
using TimeTracker.DataSources;
using TimeTracker.DataTypes;
using TimeTracker.DataTypes.Interfaces;
using TimeTracker.ViewModels.Interfaces;

namespace TimeTracker.ViewModels
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
