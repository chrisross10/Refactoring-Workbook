using System.Collections;
using System.IO;

namespace Robot
{
	public class RobotReport
	{
		public static void Report(StringWriter writer, ArrayList machines, Robot robot)
		{
			writer.Write("FACTORY REPORT\n");

			foreach (Machine machine in machines)
			{
				writer.Write("Machine " + machine.Name);
				if (machine.Bin != null)
					writer.Write(" bin=" + machine.Bin);
				writer.Write("\n");
			}
			writer.Write("\n");

			writer.Write("Robot");
			if (robot.Location != null)
				writer.Write(" location=" + robot.Location.Name);

			if (robot.Bin != null)
				writer.Write(" bin=" + robot.Bin);

			writer.Write("\n");

			writer.Write("========\n");
		}

	}
}
