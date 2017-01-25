using System.Collections.ObjectModel;
using TimeTrackerUiWpf.BaseClasses;
using TimeTrackerUiWpf.Interfaces;

namespace TimeTrackerUiWpf.ViewModels.UserControls
{
    internal class MainTabControlViewModel : ModelBase
    {
        private ObservableCollection<ITabViewModel> _tabViewModels;
        private ITabViewModel _selectedTabViewModel;

        public ObservableCollection<ITabViewModel> TabViewModels
        {
            get { return _tabViewModels; }
            set
            {
                _tabViewModels = value;
                OnPropertyChanged("TabViewModels");
            }
        }

        public ITabViewModel SelectedTabViewModel
        {
            get { return _selectedTabViewModel; }
            set
            {
                _selectedTabViewModel = value;
                OnPropertyChanged("SelectedTabViewModel");
            }
        }

        public MainTabControlViewModel()
        {
            TabViewModels = new ObservableCollection<ITabViewModel>
            {
                new NewTaskViewModel() {Header = "New task"},
                new TaskListViewModel() {Header = "Task list"}
            };
        }
    }
}
