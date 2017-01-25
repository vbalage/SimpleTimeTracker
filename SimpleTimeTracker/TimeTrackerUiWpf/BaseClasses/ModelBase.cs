using TimeTrackerUiWpf.Interfaces;

namespace TimeTrackerUiWpf.BaseClasses
{
    internal abstract class ModelBase : NotifyBase, IComponent
    {
        public string Name { get; set; }

        public string Title { get; set; }
    }
}
