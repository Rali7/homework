using System;

class MainClass
{
	public static void Main ()
	{
		long fieldGoals = long.Parse (Console.ReadLine ());
		long fieldGoalAttempts = long.Parse (Console.ReadLine ());
		long threePointFieldGoals = long.Parse (Console.ReadLine ());
		long turnovers = long.Parse (Console.ReadLine ());
		long offensiveRebounds = long.Parse (Console.ReadLine ());
		long opponentDevensiveRebounds = long.Parse (Console.ReadLine ());
		long freeThrows = long.Parse (Console.ReadLine ());
		long freeThrowAttempts = long.Parse (Console.ReadLine ());

		double eFGper = (fieldGoals + 0.5 * threePointFieldGoals) / fieldGoalAttempts;
		double TOVper = turnovers / (fieldGoalAttempts + 0.44 * freeThrowAttempts + turnovers);
		double ORBper = (double)offensiveRebounds / (offensiveRebounds + opponentDevensiveRebounds);
		double FTper = (double)freeThrows / fieldGoalAttempts;

		Console.WriteLine ("eFG% {0}", eFGper.ToString("0.000"));
		Console.WriteLine ("TOV% {0}", TOVper.ToString("0.000"));
		Console.WriteLine ("ORB% {0}", ORBper.ToString("0.000"));
		Console.WriteLine ("FT% {0}", FTper.ToString("0.000"));
	}
}