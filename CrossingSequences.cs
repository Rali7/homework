using System;

class CrossingSequences
{
	public static void Main ()
	{
		int MAX = 1000000;
		int t1 = int.Parse (Console.ReadLine ());
		int t2 = int.Parse (Console.ReadLine ());
		int t3 = int.Parse (Console.ReadLine ());

		bool[] trib = new bool[MAX + 1];
		trib [t1] = true;
		trib [t2] = true;
		trib [t3] = true;

		while (true) {
			int tNext = t1 + t2 + t3;
			if (tNext <= MAX) {
				trib [tNext] = true;
			} else {
				break;
			}
			t1 = t2;
			t2 = t3;
			t3 = tNext;
		}
		long corner = long.Parse (Console.ReadLine ());
		long step = long.Parse (Console.ReadLine ());
		bool oddCorner = true;
		long side = 0;
		bool[] spiral = new bool[MAX + 1];
		while (corner <= MAX) {
			spiral [corner] = true;
			if (oddCorner) {
				side += 1;
			}
			corner += side * step;
			oddCorner = !oddCorner;
		}
		for (int num = 1; num <= MAX; num++) {
			if (trib [num] && spiral [num]) {
				Console.WriteLine (num);
				return;
			}
		}
		Console.WriteLine ("No");
	}
}