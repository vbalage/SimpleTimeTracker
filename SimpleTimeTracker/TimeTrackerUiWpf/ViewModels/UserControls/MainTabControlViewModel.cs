using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TimeTrackerUiWpf.BaseClasses;
using TimeTrackerUiWpf.Interfaces;

namespace TimeTrackerUiWpf.ViewModels.UserControls
{
    public class MainTabControlViewModel : ModelBase
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

        public MainTabControlViewModel(IEnumerable<ITabViewModel> viewModels)
        {
            TabViewModels = new ObservableCollection<ITabViewModel>(viewModels);
            SelectedTabViewModel = TabViewModels.FirstOrDefault();
        }
    }
}
