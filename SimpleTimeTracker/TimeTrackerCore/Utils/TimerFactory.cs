using System;
using System.ComponentModel;
using TimeTracker.Interface.Timer;
using TimeTracker.Interface.Utils;
using TimeTracker.Core.Utils;

namespace TimeTracker.Core.Utils
{
    public class TimerFactory : ITimerFactory
    {
        private readonly IDateProvider _dateProvider;

        public TimerFactory(IDateProvider dateProvider)
        {
            if (dateProvider == null)
                throw new ArgumentNullException(nameof(dateProvider));

            _dateProvider = dateProvider;
        }

        public ITimer Instance()
        {
            return new Timer(1000, _dateProvider);
        }
    }
}
