namespace TimeTracker.Interface.DataTypes
{
    public interface ITask : IEntity
    {
        string Name { get; set; }

        long SessionId { get; set; }
    }
}