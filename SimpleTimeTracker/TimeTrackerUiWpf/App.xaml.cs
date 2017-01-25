using System.Windows;
using TimeTrackerUiWpf.ViewModels;
using TimeTrackerUiWpf.Views;

namespace TimeTrackerUiWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            using (var dbContext = new TimeTrackerContext())
            {
                var tc = new MainTabControl()
                {
                    DataContext = new MainTabControlViewModel(dbContext)
                };

                var window = new MainWindow()
                {
                    Title = "Simple Time Tracker",
                    DataContext = tc
                };

                window.Show();
            }
        }
    }
}
