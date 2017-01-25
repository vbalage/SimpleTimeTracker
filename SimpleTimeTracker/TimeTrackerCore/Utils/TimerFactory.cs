using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Interface.Timer;

namespace TimeTracker.Core.Utils
{
    public class TimerFactory : ITimerFactory
    {
        public ITimer Instance()
        {
            return new TimeTracker.Core.Utils.Timer();
        }
    }
}
