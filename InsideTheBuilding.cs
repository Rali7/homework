using System;

class InsideTheBuilding
{
	public static void Main ()
	{
		int height = int.Parse (Console.ReadLine ());
		int x1 = int.Parse (Console.ReadLine());
		int y1 = int.Parse (Console.ReadLine());
		int x2 = int.Parse (Console.ReadLine());
		int y2 = int.Parse (Console.ReadLine());
		int x3 = int.Parse (Console.ReadLine());
		int y3 = int.Parse (Console.ReadLine());
		int x4 = int.Parse (Console.ReadLine());
		int y4 = int.Parse (Console.ReadLine());
		int x5 = int.Parse (Console.ReadLine());
		int y5 = int.Parse (Console.ReadLine());

		Console.WriteLine (IsPositionInTheBuilding(x1, y1, height));
		Console.WriteLine (IsPositionInTheBuilding(x2, y2, height));
		Console.WriteLine (IsPositionInTheBuilding(x3, y3, height));
		Console.WriteLine (IsPositionInTheBuilding(x4, y4, height));
		Console.WriteLine (IsPositionInTheBuilding(x5, y5, height));
	}
	private static string IsPositionInTheBuilding(int x, int y, int height)
	{
		bool insideDown = 
			(x >= 0) && (x <= 3*height) && (y >= 0) && (y <= height);
		bool insideUp = 
			(x >= height) && (x <= 2*height) && (y >= height) && (y <= 4*height);
		bool inside = insideDown | insideUp;
		string result = inside ? "inside" : "outside";
		return result;
	}
}