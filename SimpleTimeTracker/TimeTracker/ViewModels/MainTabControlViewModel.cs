using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.ViewModels.Interfaces;

namespace TimeTracker.ViewModels
{   
    internal class MainTabControlViewModel
    {
        public ObservableCollection<ITabViewModel> TabViewModels { get; set; }       
        ITabViewModel SelectedTabViewModel { get; set; }

        public MainTabControlViewModel()
        {
            TabViewModels = new ObservableCollection<ITabViewModel>();
            TabViewModels.Add(new NewTaskViewModel {Header = "New task"});
        }
    }
}
