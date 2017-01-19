using System;

namespace TimeTracker.Utils.Interfaces
{
    interface ITimer
    {
        void Start();
        void Stop();
        void Pause();
        TimeSpan Elapsed { get; }
    }
}
