using System;
using System.Diagnostics;
using TimeTracker.Interface.Utils;

namespace TimeTracker.Core.Utils
{
    public class StopwatchTimer : Stopwatch, ITimer
    {
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
    }
}
