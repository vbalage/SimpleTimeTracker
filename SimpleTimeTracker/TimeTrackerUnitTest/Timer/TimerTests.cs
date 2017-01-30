using System;
using System.Threading;
using NUnit.Framework;
using TimeTracker.Core.Utils;

namespace TimeTrackerUnitTest
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

		[Test()]
		public void TimerEventTest()
		{
			int startEventCalledCount = 0;
			int endEventCalledCount = 0;
			int timeChangedCounter = 0;

			t.TimerStarted += (sender, e) => { startEventCalledCount++; };
			t.TimerStopped += (sender, e) => { endEventCalledCount++; };
			t.TimeChanged += (sender, e) => { timeChangedCounter++};

			Assert.IsFalse(t.IsRunning);
			t.Start();
			Assert.IsTrue(t.IsRunning);
			Thread.Sleep(100);
			t.Stop();
			Assert.IsFalse(t.IsRunning);

			Assert.AreEqual(1, startEventCalledCount);
			Assert.AreEqual(1, endEventCalledCount);


		}
	}
}
