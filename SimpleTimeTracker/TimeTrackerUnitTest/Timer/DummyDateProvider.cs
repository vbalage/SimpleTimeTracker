using System;
using TimeTracker.Interface.Utils;

namespace TimeTrackerUnitTest
{
	public class DummyDateProvider : IDateProvider
	{
		private DateTime _dummyDate;

		public DummyDateProvider(DateTime dummyDate)
		{
			_dummyDate = dummyDate;
		}

		public DateTime Now()
		{
			return _dummyDate;
		}
	}
}
