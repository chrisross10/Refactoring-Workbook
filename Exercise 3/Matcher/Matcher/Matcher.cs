using System;

namespace Matcher
{
	public class Matcher
	{
		public bool Match(int[] expected, int[] actual, int clipLimit, int delta)
		{
			// Clip "too-large" values
			for (int i = 0; i < actual.Length; i++)
				if (actual[i] > clipLimit)
					actual[i] = clipLimit;

			// Check for length differences
			if (actual.Length != expected.Length)
				return false;

			// Check that each entry within expected +/- delta
			for (int i = 0; i < actual.Length; i++)
				if (Math.Abs(expected[i] - actual[i]) > delta)
					return false;

			return true;
		}
	}
}