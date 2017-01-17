using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimeTracker.Interface
{
    interface ITimer
    {
        void Start();
        void Stop();
        void Pause();
        TimeSpan Elapsed { get; }
    }
}
