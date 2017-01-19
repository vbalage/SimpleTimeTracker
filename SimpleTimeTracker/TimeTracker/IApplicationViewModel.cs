using TimeTracker.DataTypes.Interfaces;

namespace TimeTracker
{
    public interface IApplicationParameters
    {
        IDataModel DataModel { get; set; }
    }
}