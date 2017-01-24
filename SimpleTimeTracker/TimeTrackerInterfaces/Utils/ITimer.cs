using System;

namespace TimeTracker.Utils.Interfaces
{
    public interface ITimer
    {
        void Start();
        void Stop();
        void Pause();
        TimeSpan Elapsed { get; }
    }
}
