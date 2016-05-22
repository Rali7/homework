using System;

class WineGlass
{
	public static void Main ()
	{
		int nEven = int.Parse (Console.ReadLine());
		char backslash = '\\';
		char asterisks = '*';
		char slash = '/';
		char dot = '.';
		char dash = '-';
		char pipe = '|';

		if (nEven >= 4 && nEven <= 60) {
			Console.Write ("{0}{1}{2}", new String (backslash, 1), 
				new String (asterisks, nEven - 2), new string (slash, 1));
			Console.WriteLine ();
			for (int i = 1; i <= (nEven / 2) - 2; i++) {
				int count = nEven - 2 * i - 2;
				Console.Write ("{0}{1}{2}{3}{0}", new string (dot, i), 
					new String (backslash, 1), new string (asterisks, count),
					new string (slash, 1));					
				Console.WriteLine ();
			}
		}

		Console.Write("{0}{1}{2}{0}", new string(dot, (nEven / 2) - 1),
			new String(backslash, 1), new string(slash, 1));
		Console.WriteLine ();

		if (nEven < 12) {
			for (int i = 0; i < (nEven / 2) - 1; i++) {
				Console.Write("{0}{1}{0}", new string(dot, (nEven / 2) - 1),
					new String(pipe, 2));
				Console.WriteLine ();
			}
			Console.Write("{0}", new string(dash, nEven));
			Console.WriteLine ();
		} else {
			for (int i = 0; i < (nEven / 2) - 2; i++) {
				Console.Write("{0}{1}{0}", new string(dot, (nEven / 2) - 1),
					new String(pipe, 2));
				Console.WriteLine ();
			}
			for (int i = 0; i < nEven / 6; i++) {
				Console.Write("{0}", new string(dash, nEven));
				Console.WriteLine ();
			}
		}
	}
}