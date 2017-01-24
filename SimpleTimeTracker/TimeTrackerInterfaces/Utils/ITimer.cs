using System;

namespace TimeTracker.Interface.Utils
{
    public interface ITimer
    {
        void Start();
        void Stop();
        void Pause();
        TimeSpan Elapsed { get; }
    }
}
