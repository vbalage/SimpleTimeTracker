using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TimeTracker.DataSources;
using TimeTracker.ViewModels;
using TimeTracker.Views;

namespace TimeTracker
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
