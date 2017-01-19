using System.Windows;

namespace TimeTracker.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            //DataContext = new MainTabControl();

            //DataContext = dbContext;
            //var session = new Session();
            //db.Sessions.Add(session);
            //db.SaveChanges();

            //var query = db.Sessions.Select(s => s).ToList();
            InitializeComponent();
        }
    }
}
