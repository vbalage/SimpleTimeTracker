using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Interface.Timer;

namespace TimeTracker.Core.Utils
{
    public class StopWatchTimerFactory : ITimerFactory
    {
        public ITimer Instance()
        {
            return new StopwatchTimer();
        }
    }
}
