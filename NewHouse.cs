using System;

class NewHouse
{
	public static void Main ()
	{
		int n = int.Parse (Console.ReadLine ());
		char dash = '-';
		char asterisk = '*';
		char pipe = '|';

		for (int i = 1; i <= n; i += 2) {
			int dashesCount = (n - i) / 2;
			int asteriskCount = i;

			Console.Write ("{0}{1}{0}", new string (dash, dashesCount),
				new String (asterisk, asteriskCount));
				Console.WriteLine ();
		}
		for (int i = 1; i <= n; i++) {
			Console.Write ("{0}{1}{0}", new string(pipe, 1),
				new String(asterisk, n - 2));
			Console.WriteLine ();
		}
	}
}