using System;

class Cinema
{
	public static void Main ()
	{
		System.Threading.Thread.CurrentThread.CurrentCulture =
			System.Globalization.CultureInfo.CurrentCulture;

		string typeOfProjection = Console.ReadLine ();
		int rows = int.Parse (Console.ReadLine ());
		int columns = int.Parse (Console.ReadLine ());
		decimal premiere = 12.00m;
		decimal normal = 7.50m;
		decimal discount = 5.00m;
		decimal incomes = 0m;

		for (int i = 1; i <= rows; i++) {
			for (int j = 1; j <= columns; j++) {
				if (typeOfProjection == "Premiere") {
					incomes = (decimal)(i * j) * premiere;
				} else if (typeOfProjection == "Normal") {
					incomes = (decimal)(i * j) * normal;
				} else if (typeOfProjection == "Discount") {
					incomes = (decimal)(i * j) * discount;
				}
			}
		}
		Console.WriteLine ("{0:F} leva", incomes);
	}
}