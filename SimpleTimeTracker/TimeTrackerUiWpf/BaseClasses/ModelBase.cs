using TimeTrackerUiWpf.Interfaces;

namespace TimeTrackerUiWpf.BaseClasses
{
    public abstract class ModelBase : NotifyBase, IComponent
    {
        public string Name { get; set; }

        public string Title { get; set; }
    }
}
