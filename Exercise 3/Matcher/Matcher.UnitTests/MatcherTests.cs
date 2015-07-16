using NUnit.Framework;

namespace Matcher.UnitTests
{
	[TestFixture]
	public class MatcherTests
	{
		[Test]
		public void TestMatch()
		{
			Matcher matcher = new Matcher();
			int[] expected = new int[] { 10, 50, 30, 98 };
			int clipLimit = 100;
			int delta = 5;

			int[] actual = new int[] { 12, 55, 25, 110 };
			Assert.IsTrue(matcher.Match(expected, actual, clipLimit, delta));
			actual = new int[] { 10, 60, 30, 98 };
			Assert.IsTrue(!matcher.Match(expected, actual, clipLimit, delta));
			actual = new int[] { 10, 50, 30 };
			Assert.IsTrue(!matcher.Match(expected, actual, clipLimit, delta));
		}
	}
}