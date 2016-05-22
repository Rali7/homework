using System;

class SumOfElements
{
	public static void Main ()
	{
		string input = Console.ReadLine ();
		string[] sequence = input.Split (' ');
		long sum = 0;
		int maxCount = 0;

		long max = int.Parse (sequence [0]);
		for (int i = 0; i < sequence.Length; i++) {
			if (max < long.Parse (sequence [i])) {
				max = long.Parse (sequence [i]);
			}
		}

		for (int i = 0; i < sequence.Length; i++) {
			if (max == long.Parse (sequence [i])) {
				maxCount++;
				if (maxCount == 1)
					continue;
			} 
			sum += long.Parse (sequence [i]);
		}
			
		if (sum == max) {
			Console.WriteLine ("Yes, sum={0}", sum);
		}
		else
			Console.WriteLine ("No, diff={0}", Math.Abs (max - sum));
	}
}