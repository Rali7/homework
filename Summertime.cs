using System;

class MainClass
{
	public static void Main ()
	{
		int n = int.Parse (Console.ReadLine ());
		char star = '*';
		char dot = '.';
		char monkey = '@';
		char space = ' ';
		int wight = n + 1;

		Console.Write (new String(star, n + 1));
		Console.WriteLine ();

		for (int i = 0; i < n - n / 2; i++) {
			Console.Write ("{0}{1}{2}{1}",new string(space, n / 2), 
				new String(star, 1), 
				new String(space, n - 1));
			Console.WriteLine ();
		}

		for (int i = 1; i <= n / 2; i++) {
			if(i > 1){
				Console.Write ("{0}{1}{2}{1}", new string(space, n / 2 - i),
					new String(star, 1), new string(space, wight));
				Console.WriteLine ();
				wight++;
			}
		}

		for (int i = 0; i < 2*n; i++) {
			if (i < n) {
				Console.Write ("{0}{1}{0}", new string(star, 1),
					new String(dot, 2 * n - 2));
				Console.WriteLine ();
			} else {
				Console.Write ("{0}{1}{0}", new string(star, 1),
					new String(monkey, 2*n - 2));
				Console.WriteLine ();
			}
		}
		Console.Write(new String(star, 2*n));
	}
}