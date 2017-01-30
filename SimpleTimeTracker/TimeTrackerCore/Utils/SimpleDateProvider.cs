using System;
using TimeTracker.Interface.Utils;

namespace TimeTracker.Core.Utils
{
	public class SimpleDateProvider : IDateProvider
	{
		public DateTime Now()
		{
			return DateTime.Now;
		}
	}
}
