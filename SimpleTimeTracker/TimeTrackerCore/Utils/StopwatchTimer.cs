﻿using System;
using System.Diagnostics;
using TimeTracker.Utils.Interfaces;

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
            throw new NotImplementedException();
        }
    }
}