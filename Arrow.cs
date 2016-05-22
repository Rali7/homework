using System;

class Arrow
{
	public static void Main ()
	{
		int n = int.Parse (Console.ReadLine());
		char dot = '.';
		char sharp = '#';
		int outerDotsCount = 1;
		int innerDotsCount = 2 * n - 5;

		Console.Write("{0}{1}{0}", new string(dot, (n - 1) / 2),
			new String(sharp, n));
		Console.WriteLine ();
		for (int i = 0; i < n - 2; i++) {
			Console.Write ("{0}#{1}#{0}", new string(dot, (n - 1) / 2),
				new String(dot, n-2));
			Console.WriteLine ();
		}
		Console.Write ("{0}{1}{0}", new string(sharp, (n + 1) / 2),
			new String(dot, n-2));
		Console.WriteLine ();
		for (int i = 0; i < n - 2; i++) {
			Console.Write ("{0}{1}{2}{1}{0}", new string (dot, outerDotsCount),
				new String (sharp, 1), new string (dot, innerDotsCount));
			Console.WriteLine ();
			outerDotsCount += 1;
			innerDotsCount -= 2;
		}
		Console.Write ("{0}#{0}", new string(dot, n - 1));
		Console.WriteLine ();
	}
}