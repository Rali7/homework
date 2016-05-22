using System;

class HalfSum
{
	public static void Main (string[] args)
	{
		int sumFirst = 0;
		int sumSecond = 0;
		int number = int.Parse (Console.ReadLine ());
		for (int i = 0; i < number; i++) {

			int halfSequenceFirst = int.Parse (Console.ReadLine());
			sumFirst += halfSequenceFirst;
		}
		for (int i = 0; i < number; i++) {

			int halfSumSecond = int.Parse (Console.ReadLine());
			sumSecond += halfSumSecond;
		}
		if(sumFirst == sumSecond)
			Console.WriteLine ("Yes, sum=" + sumFirst);
		else
			Console.WriteLine ("No, diff=" + Math.Abs(sumFirst - sumSecond));
	}
}