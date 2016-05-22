using System;

class TheExplorer
{
	public static void Main ()
	{
		int n = int.Parse (Console.ReadLine ());
		char asterisk = '*';
		char dash = '-';
		int outerDashesCount = n / 2;
		int innerDashesCount = 1;
		int asteriskCount = 1;

		for (int i = 0; i < n; i++) {
			if (i == 0) {
				Console.Write ("{0}{1}{0}", new string (dash, outerDashesCount),
					new String (asterisk, asteriskCount));
				Console.WriteLine ();
			} else if (i > 0 && i <= n / 2) {
				outerDashesCount--;
				Console.Write ("{0}{1}{2}{1}{0}", new string (dash, outerDashesCount),
					new String (asterisk, asteriskCount), 
					new string (dash, innerDashesCount));
				Console.WriteLine ();
				innerDashesCount += 2;
			} else if (i >= n - n / 2 && i < n - 1) {
				innerDashesCount -= 2;
				outerDashesCount++;
				innerDashesCount -= 2;
				Console.Write ("{0}{1}{2}{1}{0}", new string (dash, outerDashesCount),
					new String (asterisk, asteriskCount), 
					new string (dash, innerDashesCount));
				Console.WriteLine ();
				innerDashesCount += 2;
			} else if (i == n - 1) {
				outerDashesCount++;
				Console.Write ("{0}{1}{0}", new string (dash, outerDashesCount),
					new String (asterisk, asteriskCount));
				Console.WriteLine ();
				innerDashesCount += 2;
			}
		}
	}
}