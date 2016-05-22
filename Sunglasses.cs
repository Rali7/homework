using System;

class Sunglasses
{
	public static void Main ()
	{
		int n = int.Parse (Console.ReadLine ());
		char asterisk = '*';
		char rightPipe = '/';
		char pipe = '|';
		char empty = ' ';

		Console.Write ("{0}{1}{0}", new String (asterisk, 2 * n), new String (empty, n));
		Console.WriteLine ();

		for (int i = 1; i <= n - 2; i++) {
			if (i == n / 2) {
				Console.Write ("{0}{1}{0}{2}{0}{1}{0}",
					new String (asterisk, 1), 
					new String (rightPipe, 2 * n - 2),
					new String (pipe, n));
			} 
			else{
				Console.Write ("{0}{1}{0}{2}{0}{1}{0}", 
					new String (asterisk, 1), 
					new String (rightPipe, 2 * n - 2),
					new String (empty, n));
			}
			Console.WriteLine ();
		}

		Console.Write ("{0}{1}{0}", new String (asterisk, 2 * n), new String (empty, n));
		Console.WriteLine ();
	}
}