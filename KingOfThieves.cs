using System;

class KingOfTheives
{
	public static void Main (string[] args)
	{
		int n = int.Parse (Console.ReadLine());
		char symbol = Console.ReadLine()[0];

		int outerDashes = n / 2;
		int innerSymbols = 1;

		for (int i = 0; i < n; i++) {
			Console.WriteLine (
				"{0}{1}{0}", new string('-', outerDashes), new string(symbol, innerSymbols));
			if (i < n / 2) {
				innerSymbols += 2;
				outerDashes--;
			} else {
				innerSymbols -= 2;
				outerDashes++;
			}
		}
	}
}