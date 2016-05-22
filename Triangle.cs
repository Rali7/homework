using System;

class Triangle
{
	public static void Main ()
	{
		System.Threading.Thread.CurrentThread.CurrentCulture = 
			System.Globalization.CultureInfo.CurrentCulture;

		int Ax = int.Parse (Console.ReadLine());
		int Ay = int.Parse (Console.ReadLine());
		int Bx = int.Parse (Console.ReadLine());
		int By = int.Parse (Console.ReadLine());
		int Cx = int.Parse (Console.ReadLine());
		int Cy = int.Parse (Console.ReadLine());

		double distanceAandB = Math.Sqrt(Math.Pow ((double)(Bx - Ax), 2) + Math.Pow ((double)(By - Ay), 2));
		double distanceBandC = Math.Sqrt(Math.Pow ((double)(Bx - Cx), 2) + Math.Pow ((double)(By - Cy), 2));
		double distanceAandC = Math.Sqrt(Math.Pow ((double)(Ax - Cx), 2) + Math.Pow ((double)(Ay - Cy), 2));

		if ((distanceAandB + distanceBandC) > distanceAandC &&
		    (distanceAandB + distanceAandC) > distanceBandC &&
		    (distanceAandC + distanceBandC) > distanceAandB) {
			double p = (distanceAandB + distanceAandC + distanceBandC) / 2;
			double area = Math.Sqrt (p * (p-distanceAandB) *
				(p-distanceBandC) * (p-distanceAandC));
			Console.WriteLine ("Yes");
			Console.WriteLine ("{0:F}", area);
		} else {
			Console.WriteLine ("No");
			Console.WriteLine ("{0:F}", distanceAandB);
		}
	}
}