using System;

namespace TimeTracker.Models.Interfaces
{
    interface ITimer
    {
        void Start();
        void Stop();
        void Pause();
        TimeSpan Elapsed { get; }
    }
}
