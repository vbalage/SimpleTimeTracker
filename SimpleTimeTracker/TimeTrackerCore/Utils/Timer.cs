using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using TimeTracker.Interface.Timer;

namespace TimeTracker.Core.Utils
{
    public class Timer : System.Timers.Timer, ITimer
    {
        private long _elapsedTimeTicksTicks;
        private DateTime _startTime;

        public event EventHandler TimeChanged;
        public event EventHandler TimerStarted;
        public event EventHandler TimerStopped;

        public Timer() : base(1000)
        {
            this.AutoReset = true;
            this.Elapsed += (sender, args) =>
            {
                _elapsedTimeTicksTicks = DateTime.Now.Ticks - _startTime.Ticks;
                TimeChanged?.Invoke(this, EventArgs.Empty);
            };
        }

		public Timer(int updateIntervalInMs) : base(updateIntervalInMs)
		{
		}

        public long ElapsedTimeTicks => _elapsedTimeTicksTicks;

        public bool IsRunning => Enabled;

        public void Pause()
        {
            TimerStopped?.Invoke(this,EventArgs.Empty);
            base.Stop();
        }

        public new void Start()
        {
            base.Start();
            TimerStarted?.Invoke(this,EventArgs.Empty);
            _startTime = DateTime.Now;
        }

        public new void Stop()
        {
            TimerStopped?.Invoke(this, EventArgs.Empty);
            base.Stop();
        }
    }
}
