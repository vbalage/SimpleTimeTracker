﻿using System.Windows;
using TimeTrackerUiWpf.ViewModels;
using TimeTrackerUiWpf.ViewModels.UserControls;
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
            var tc = new MainTabControl()
            {
                DataContext = new MainTabControlViewModel()
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
