using System;

class WorkHours
{
	public static void Main ()
	{
		const double bikingDays = 0.1;
		const int hoursPerDay = 12;

		int projectHours = int.Parse (Console.ReadLine ());
		int projectDays = int.Parse (Console.ReadLine ());
		int productivity = int.Parse(Console.ReadLine());

		double efficientWorkHours = (double)(((projectDays - projectDays * bikingDays)
			* hoursPerDay) * productivity) / (double)100;
		int roundedWorkHours = (int)Math.Floor (efficientWorkHours);
		int difference = roundedWorkHours - projectHours;
		if (difference < 0) {
			Console.WriteLine ("No");
			Console.WriteLine (difference);
		} else {
			Console.WriteLine ("Yes");
			Console.WriteLine (difference);
		}
	}
}