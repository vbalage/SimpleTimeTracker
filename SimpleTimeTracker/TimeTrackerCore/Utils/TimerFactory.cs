using System;
using TimeTracker.Interface.Timer;
using TimeTracker.Interface.Utils;

namespace TimeTracker.Core.Utils
{
    public class TimerFactory : ITimerFactory
    {
		private IDateProvider _dateProvider;

		public TimerFactory(IDateProvider dateProvider)
		{
			if (dateProvider == null)
				throw new ArgumentNullException(nameof(dateProvider));

			_dateProvider = dateProvider;
		}

		public ITimer Instance()
        {
            return new TimeTracker.Core.Utils.Timer(1000, _dateProvider);
        }
    }
}
