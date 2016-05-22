using System;

class House
{
	public static void Main ()
	{
		int n = int.Parse (Console.ReadLine());
		char asterisk = '*';
		char dot = '.';
		int outerDotsCount = (n - 1) / 2;
		int innerDotsCount = 1;

		for (int i = 1; i < (n + 1) / 2; i++) {
			if (i == 1) {
				Console.Write ("{0}{1}{0}", new string (dot, outerDotsCount),
					new String (asterisk, 1));
				Console.WriteLine ();
			} else if (i > 0) {
				outerDotsCount --;
				Console.Write ("{0}{1}{2}{1}{0}", new string(dot, outerDotsCount),
					new String(asterisk, 1), new string(dot, innerDotsCount));
				Console.WriteLine ();
				innerDotsCount += 2;
			}
		} Console.Write(new String(asterisk, n));
		Console.WriteLine ();
		for (int i = 0; i < (n - 1) / 2; i++) {
			int wallDistance = n / 4;
			if (i == (n - 1) / 2 - 1) {
				Console.Write ("{0}{1}{0}", new string (dot, wallDistance),
					new String (asterisk, n - 2 * wallDistance));
				Console.WriteLine ();
			} else {
				Console.Write ("{0}{1}{2}{1}{0}", new string (dot, n / 4),
					new String (asterisk, 1), 
					new string (dot, n - 2 * wallDistance - 2));
				Console.WriteLine ();
			}
		}
	}
}