using System;

class BookProblem
{
	public static void Main ()
	{
		const int monthDays = 30;
		const int monthsInYear = 12;

		int bookPages = int.Parse (Console.ReadLine());
		int campingDays = int.Parse (Console.ReadLine());
		int readPages = int.Parse (Console.ReadLine());

		if (campingDays >= 30 || readPages <= 0 || bookPages <= 0) {
			Console.WriteLine ("never");
			return;
		} else {
			int normalDays = monthDays - campingDays;
			int allNeededMonths = (int)Math.Ceiling((double)bookPages / 
				(normalDays * readPages));
			int years = allNeededMonths / monthsInYear;
			int months = allNeededMonths % monthsInYear;
			Console.WriteLine ("{0} years {1} months", years, months);
		}
	}
}