using NUnit.Framework;
using System;
using TimeTracker.Core.DataTypes;

namespace TimeTrackerUnitTest
{
	[TestFixture]
	public class Test
	{
		Task t;

		[SetUp]
		public void Init()
		{
			t = new Task();
		}

		[Test()]
		public void PropertyTest()
		{
			var taskName = "TestTask";
			t.Name = taskName;
			StringAssert.AreEqualIgnoringCase(t.Name, taskName);
		}
	}
}
