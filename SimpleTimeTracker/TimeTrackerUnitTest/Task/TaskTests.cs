using NUnit.Framework;

namespace TimeTrackerUnitTest.Task
{
	[TestFixture]
	public class TaskTests
	{
		TimeTracker.Core.DataTypes.Task t;

		[SetUp]
		public void Init()
		{
			t = new TimeTracker.Core.DataTypes.Task();
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
