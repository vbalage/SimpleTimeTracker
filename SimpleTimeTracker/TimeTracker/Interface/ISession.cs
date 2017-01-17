using System;

namespace TimeTracker.Interface
{
    public interface ISession
    {
        string Description { get; set; }
        ITask ParentTask { get; set; }
        DateTime EndTime { get; }
        DateTime StartTime { get; }
        TimeSpan Length { get; }
        bool HasEnded { get; }

        void Start();
        void Pause();
        void Stop();
    }
}