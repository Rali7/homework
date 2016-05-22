using System;

class Illuminati
{
	public static void Main ()
	{
		string input = Console.ReadLine ();
		input = input.ToUpper ();
		int count = 0;
		int sum = 0;

		for (int i = 0; i < input.Length; i++) {
			char letter = input [i];
			if (letter == 'A' || letter == 'E' ||
			   letter == 'I' || letter == 'O' ||
			   letter == 'U') {
				sum += letter;
				count++;
			}
		}
		Console.WriteLine ("{0}\n{1}", count, sum);
	}
}