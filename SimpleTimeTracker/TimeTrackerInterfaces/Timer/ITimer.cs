using System;
using System.Security.Policy;

namespace TimeTracker.Interface.Timer
{
    public interface ITimer : IDisposable
    {
        event EventHandler TimeChanged;
        event EventHandler TimerStarted;
        event EventHandler TimerStopped;

        bool IsRunning { get; }
        long ElapsedTimeTicks { get; }
        void Start();
        void Stop();
        void Pause();
    }
}
