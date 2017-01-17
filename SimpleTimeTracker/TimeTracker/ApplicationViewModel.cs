using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Interface;
using TimeTracker.Model;
using TimeTracker.View;

namespace TimeTracker
{
    internal class ApplicationViewModel
    {       
        public ObservableCollection<ITabItem> TabItems { get; set; }

        public ApplicationParameters AppParams { get; set; }

        private ITabItem _selectedTab;
        public ITabItem SelectedTab
        {
            get { return _selectedTab; }
            set { _selectedTab = value; }
        }

        public ApplicationViewModel()
        {
            TabItems = new ObservableCollection<ITabItem>();

            AppParams = new ApplicationParameters
            {
                DataModel = new DataModel()
            };

            TabItems.Add(new TaskListViewTab(AppParams));
            var newTaskTab = new NewTaskTab(new NewTaskView());
            TabItems.Add(newTaskTab);

            SelectedTab = TabItems[0];            
        }
    }
}
