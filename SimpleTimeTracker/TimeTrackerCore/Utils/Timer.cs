using System;
using TimeTracker.Interface.Timer;
using TimeTracker.Interface.Utils;

namespace TimeTracker.Core.Utils
{
    public class Timer : System.Timers.Timer, ITimer
    {
        private long _elapsedTimeTicksTicks;
        private DateTime _startTime;
		private IDateProvider _dateProvider;

        public event EventHandler TimeChanged;
        public event EventHandler TimerStarted;
        public event EventHandler TimerStopped;

		public Timer(int updateIntervalInMs, IDateProvider dateProvider) : base(updateIntervalInMs)
		{
			if (dateProvider == null)
				throw new ArgumentNullException(nameof(dateProvider));
			
			_dateProvider = dateProvider;

			AutoReset = true;
			Elapsed += (sender, args) =>
			{
				_elapsedTimeTicksTicks = _dateProvider.Now().Ticks - _startTime.Ticks;
				TimeChanged?.Invoke(this, EventArgs.Empty);
			};
		}

        public long ElapsedTimeTicks => _elapsedTimeTicksTicks;

        public bool IsRunning => Enabled;

        public void Pause()
        {
			base.Stop();
            TimerStopped?.Invoke(this,EventArgs.Empty); 
        }

        public new void Start()
        {
            base.Start();
            TimerStarted?.Invoke(this,EventArgs.Empty);
			_startTime = _dateProvider.Now();
        }

        public new void Stop()
        {
            TimerStopped?.Invoke(this, EventArgs.Empty);
            base.Stop();
        }
    }
}
