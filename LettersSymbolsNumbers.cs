using System;
using System.Text.RegularExpressions;

class LettersSymbolsNumbers
{
	public static void Main ()
	{
		int n = int.Parse (Console.ReadLine ());
		long letterSum = 0;
		long symbolSum = 0;
		long numberSum = 0;
		for (int i = 0; i < n; i++) {
			string input = Console.ReadLine ();
			input = input.ToUpper ();
			input = Regex.Replace (input, "\\s+", "");
			for (int j = 0; j < input.Length; j++) {
				char currentChar = input [j];
				if (currentChar >= 'A' && currentChar <= 'Z') {
					letterSum += (currentChar - 'A' + 1) * 10;
				} else if (currentChar >= '0' && currentChar <= '9') {
					numberSum += (currentChar - '0') * 20;
				} else{
					symbolSum += 200;
				}
			}
		}
		Console.WriteLine (letterSum);
		Console.WriteLine (numberSum);
		Console.WriteLine (symbolSum);
	}
}