using System;

class ExamPrepare
{
	public static void Main (string[] args)
	{
		string isLeap = Console.ReadLine();
		int holidays = int.Parse (Console.ReadLine());
		int totalWeekends = 52;
		int weekendsPlay = int.Parse (Console.ReadLine());
		int normalWeekends = totalWeekends - weekendsPlay;
		int leapYear = 3;
		double totalPlays = Math.Floor (weekendsPlay + (double)(normalWeekends * 2) / 3 + 
			(double)(holidays / 2));

		if (isLeap == "t") {
			Console.WriteLine (totalPlays + leapYear);
		}
		else if(isLeap == "f")
			Console.WriteLine (totalPlays);

	}
}