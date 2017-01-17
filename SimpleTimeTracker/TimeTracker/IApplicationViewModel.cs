using TimeTracker.Interface;

namespace TimeTracker
{
    public interface IApplicationParameters
    {
        IDataModel DataModel { get; set; }
    }
}