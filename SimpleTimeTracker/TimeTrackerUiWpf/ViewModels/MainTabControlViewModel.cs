using System;
using System.Collections.ObjectModel;
using TimeTrackerUiWpf.Interfaces;

namespace TimeTrackerUiWpf.ViewModels
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
