using System;
using System.Collections;
using System.IO;
using NUnit.Framework;

namespace Robot.UnitTests
{
	[TestFixture]
	public class ReportTest
	{
		[Test]
		public void TestReport()
		{
			ArrayList line = new ArrayList();
			line.Add(new Machine("mixer", "left"));

			Machine extruder = new Machine("extruder", "center");
			extruder.Put("paste");
			line.Add(extruder);

			Machine oven = new Machine("oven", "right");
			oven.Put("chips");
			line.Add(oven);

			Robot robot = new Robot();
			robot.MoveTo(extruder);
			robot.Pick();

			StringWriter writer = new StringWriter();
			RobotReport.Report(writer, line, robot);

			String expected =
				"FACTORY REPORT\n" +
				"Machine mixer\nMachine extruder\n" +
				"Machine oven bin=chips\n\n" +
				"Robot location=extruder bin=paste\n" +
				"========\n";

			Assert.That(writer.ToString(), Is.EqualTo(expected));
		}
	}
}
