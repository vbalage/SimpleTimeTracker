using System;
using NUnit.Framework;

namespace TimeTrackerUnitTest.Timer
{
	[TestFixture]
	public class TimerTests
	{
		TimeTracker.Core.Utils.Timer t;

		[SetUp]
		public void Init()
		{
			DateTime myDate = DateTime.ParseExact("2017-01-01 00:00:00,000", "yyyy-MM-dd HH:mm:ss,fff",
												  System.Globalization.CultureInfo.InvariantCulture);
			var timeResolutionInterval = 1000; //ms
			t = new TimeTracker.Core.Utils.Timer(timeResolutionInterval, new DummyDateProvider(myDate));
		}

		[Test]
		public void TimerEventTest()
		{
			int startEventCalledCount = 0;
			int endEventCalledCount   = 0;
			int timeChangedCounter    = 0;

			t.TimerStarted += (sender, e) => { startEventCalledCount++; };
			t.TimerStopped += (sender, e) => { endEventCalledCount++; };

			Assert.IsFalse(t.IsRunning);
			t.Start();
			Assert.IsTrue(t.IsRunning);

			t.TimeChanged +=
				(sender, e) =>
					{
						timeChangedCounter++;
						t.Stop();
						Assert.IsFalse(t.IsRunning);
						Assert.AreEqual(1, startEventCalledCount, $"Start event called {startEventCalledCount} times.");
						Assert.AreEqual(1, endEventCalledCount,   $"End event called {endEventCalledCount} times.");
					};
		}
	}
}
