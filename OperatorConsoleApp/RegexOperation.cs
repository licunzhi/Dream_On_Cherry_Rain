using System;
using System.Text.RegularExpressions;

namespace OperatorConsoleApp
{
	public class RegexOperation
	{
		public RegexOperation()
		{
		}

		// Test the regex
		public static void TestRegexFunction()
		{
            string str = "C#TestDemo C#LearningProcess Validation for dot";
            MatchCollection mcs = Regex.Matches(str, @"\bC\S*");
			foreach (Match mc in mcs)
			{
				Console.WriteLine(mc);
			}
        }
	}
}

