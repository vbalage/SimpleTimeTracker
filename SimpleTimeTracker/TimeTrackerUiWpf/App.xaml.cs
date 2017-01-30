using System;
using Autofac;
using System.Windows;
using TimeTracker.Core.Utils;
using TimeTracker.Interface.Timer;
using TimeTracker.Interface.Utils;
using TimeTrackerUiWpf.Utils;
using TimeTrackerUiWpf.ViewModels;
using TimeTrackerUiWpf.ViewModels.UserControls;
using TimeTrackerUiWpf.Views;
using TimeTrackerUiWpf.Views.Tabs;
using System.Windows.Controls;
using TimeTrackerUiWpf.Interfaces;

namespace TimeTrackerUiWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static IContainer Container { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            ContainerBuilder builder = new Autofac.ContainerBuilder();
            builder.RegisterType<SimpleDateProvider>().As<IDateProvider>().SingleInstance();
            builder.RegisterType<TimerFactory>().As<ITimerFactory>().SingleInstance();
            builder.RegisterType<MainWindow>().As<Window>();
            builder.RegisterType<MainTabControlViewModel>();
            builder.RegisterType<NewTaskViewModel>().As<ITabViewModel>();
            builder.RegisterType<TaskListViewModel>().As<ITabViewModel>();
            var container = builder.Build();

            using (var lifeTimeScope = container.BeginLifetimeScope())
            {
                var win = container.Resolve<Window>();
                win.Title = "Simple Time Tracker";
                win.DataContext = container.Resolve<MainTabControlViewModel>();
                ResourceUtils.SetLanguageDictionary(this);
                win.Show();
            }            
        }
    }
}
