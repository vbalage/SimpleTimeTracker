using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using TimeTracker.DataSources;
using TimeTracker.ViewModels.Interfaces;

namespace TimeTracker.ViewModels
{   
    internal class MainTabControlViewModel
    {
        public ObservableCollection<ITabViewModel> TabViewModels { get; set; }       
        ITabViewModel SelectedTabViewModel { get; set; }

        public MainTabControlViewModel(TimeTrackerContext dbContext)
        {
            if(dbContext == null)
                throw new ArgumentNullException(nameof(dbContext));

            TabViewModels = new ObservableCollection<ITabViewModel>();
            TabViewModels.Add(new NewTaskViewModel(dbContext) {Header = "New task"});
            TabViewModels.Add(new TaskListViewModel(dbContext) {Header = "Task list"});
        }
    }
}
