using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Model
{
    internal class StopwatchTimer : Stopwatch, ITimer
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
            throw new NotImplementedException();
        }
    }
}
