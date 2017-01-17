using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TimeTracker.ViewModel;

namespace TimeTracker.View
{
    /// <summary>
    /// Interaction logic for TaskList.xaml
    /// </summary>
    public partial class TaskListViewTab : ITabItem
    {
        private IApplicationParameters _app;

        public TaskListViewTab(IApplicationParameters app)
        {
            if (app == null)
                throw new ArgumentNullException(nameof(app));

            _app = app;

            InitializeComponent();
            DataContext = new TaskListViewTabViewModel(_app);
        }
    }
}
