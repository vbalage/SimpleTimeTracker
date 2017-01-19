using TimeTracker.DataTypes.Interfaces;

namespace TimeTracker.Models
{
    public class ApplicationParameters : IApplicationParameters
    {
        public IDataModel DataModel { get; set; }
    }
}
