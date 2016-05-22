using System;

class ChessBoardGame
{
	public static void Main (string[] args)
	{
		int n = int.Parse (Console.ReadLine ());
		string input = Console.ReadLine ();
		string firstTeam = "black team";
		string secondTeam = "white team";

		int sumBlack = 0;
		int sumWhite = 0;

		for (int i = 0; i < input.Length; i++) {
			if (i >= n * n) {
				break;
			}
			if (i % 2 == 0 && char.IsUpper (input [i])) {
				sumWhite += input [i];
			} else if (i % 2 == 0 && char.IsLetterOrDigit (input [i])) {
				sumBlack += input [i];
			} else if (i % 2 != 0 && char.IsUpper (input [i])) {
				sumBlack += input [i];
			} else if (i % 2 != 0 && char.IsLetterOrDigit (input [i])) {
				sumWhite += input[i];
			}
		}
		if (sumBlack == sumWhite)
			Console.WriteLine ("Equal result: {0}", sumBlack);
		else 
			Console.WriteLine ("The winner is: {0}\n{1}",
				sumBlack > sumWhite ? firstTeam : secondTeam ,
				Math.Abs (sumBlack - sumWhite));
	}
}