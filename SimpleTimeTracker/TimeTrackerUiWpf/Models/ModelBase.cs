using TimeTrackerUiWpf.Interfaces;

namespace TimeTrackerUiWpf.Models
{
    internal abstract class ModelBase : IComponent
    {
        public string Name { get; set; }

        public string Title { get; set; }
    }
}
