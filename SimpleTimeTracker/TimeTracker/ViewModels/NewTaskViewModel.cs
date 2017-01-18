using System.Threading.Tasks;
using TimeTracker.Models;
using TimeTracker.Models.Interfaces;
using TimeTracker.ViewModels.Interfaces;

namespace TimeTracker.ViewModels
{
    public class NewTaskViewModel : ITabViewModel
    {
        public string Header { get; set; }
        public ITask Task { get; set; }

        public NewTaskViewModel()
        {
            Task = new ProjectTask();
        }
    }
}
