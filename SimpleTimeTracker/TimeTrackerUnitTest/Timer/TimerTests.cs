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
			t = new TimeTracker.Core.Utils.Timer();
		}

		[Test()]
		public void TimerEventTest()
		{
			int startEventCalledCount = 0;
			int endEventCalledCount = 0;

			t.TimerStarted += (sender, e) => { startEventCalledCount++; };
			t.TimerStopped += (sender, e) => { endEventCalledCount++; };

			Assert.IsFalse(t.IsRunning);
			t.Start();
			Assert.IsTrue(t.IsRunning);
			t.Stop();
			Assert.IsFalse(t.IsRunning);

			Assert.AreEqual(1, startEventCalledCount);
			Assert.AreEqual(1, endEventCalledCount);

		}
	}
}
