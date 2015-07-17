using NUnit.Framework;

namespace Robot.UnitTests
{
	[TestFixture]
	public class RobotTests
	{
		[Test]
		public void TestRobot()
		{
			Machine sorter = new Machine("Sorter", "left");
			sorter.Put("chips");
			Machine oven = new Machine("Oven", "middle");
			Robot robot = new Robot();

			Assert.That("chips", Is.EqualTo(sorter.Bin));
			Assert.IsNull(oven.Bin);
			Assert.IsNull(robot.Location);
			Assert.IsNull(robot.Bin);

			robot.MoveTo(sorter);
			robot.Pick();
			robot.MoveTo(oven);
			robot.Release();

			Assert.IsNull(robot.Bin);
			Assert.That(oven, Is.EqualTo(robot.Location));
			Assert.IsNull(sorter.Bin);
			Assert.That("chips", Is.EqualTo(oven.Bin));
		}
	}
}
