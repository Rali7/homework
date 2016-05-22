using System;

class MelonsAndWatermelons
{
	public static void Main ()
	{
		int startingDay = int.Parse (Console.ReadLine ());
		int consecutiveDays = int.Parse (Console.ReadLine ());

		int watermelons = 0;
		int melons = 0;

		for (int i = startingDay; i < startingDay + consecutiveDays; i++) {

			switch (i % 7) {
			case 1:
				watermelons += 1;
				break;
			case 2:
				melons += 2;
				break;
			case 3:
				watermelons += 1;
				melons += 1;
				break;
			case 4:
				watermelons += 2;
				break;
			case 5:
				watermelons += 2;
				melons += 2;
				break;
			case 6:
				watermelons += 1;
				melons += 2;
				break;
			default:
				break;
			}
		}
			int diff = Math.Abs (melons - watermelons);
			if (watermelons > melons)
				Console.WriteLine ("{0} more watermelons", diff);
			else if (melons > watermelons)
				Console.WriteLine ("{0} more melons", diff);
			else
				Console.WriteLine ("Equal amount: {0}", melons);
	}
}