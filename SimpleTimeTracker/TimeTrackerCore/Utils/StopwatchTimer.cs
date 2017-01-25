using System;
using System.Diagnostics;
using TimeTracker.Interface.Timer;

namespace TimeTracker.Core.Utils
{
    public class StopwatchTimer : Stopwatch, ITimer
    {
        public long ElapsedTimeTicks
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public event EventHandler TimeChanged;
        public event EventHandler TimerStarted;
        public event EventHandler TimerStopped;

        public new void Start()
        {
            base.Start();
        }

        public new void Stop()
        {
            base.Stop();
        }

        public void Pause()
        {            
            base.Stop();            
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
