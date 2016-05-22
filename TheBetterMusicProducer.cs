using System;

class TheBetterMusicProducer
{
	public static void Main ()
	{
		const double euroInLeva = 1.94;
		const double dollarInLeva = 1.72;
		const double levInPessos = 332.74;

		int albumsSoldEurope = int.Parse (Console.ReadLine ());
		double priceOfAlbumEuro = double.Parse (Console.ReadLine ());

		int albumsSoldNorthAmerica = int.Parse (Console.ReadLine ());
		double priceOfAlbumDollar = double.Parse (Console.ReadLine ());

		int albumsSoldSouthAmerica = int.Parse (Console.ReadLine ());
		double priceOfAlbumPessos = double.Parse (Console.ReadLine ());

		int concertsInTour = int.Parse (Console.ReadLine ());
		double profitFromOneConcert = double.Parse (Console.ReadLine ());

		double firstOfferLeva = albumsSoldEurope * priceOfAlbumEuro * euroInLeva +
		                    albumsSoldNorthAmerica * priceOfAlbumDollar * dollarInLeva +
		                    (albumsSoldSouthAmerica * priceOfAlbumPessos) / levInPessos;
		firstOfferLeva = ((1-0.35)-0.2*(1-0.35)) * firstOfferLeva;

		double secondOfferLeva = profitFromOneConcert * concertsInTour * euroInLeva;
		if (secondOfferLeva > 100000) {
			secondOfferLeva = (1 - 0.15) * secondOfferLeva;
		}
			if (firstOfferLeva > secondOfferLeva) {
				Console.WriteLine ("Let's record some songs! They'll bring us {0:F}lv.",
					firstOfferLeva);
			} else {
				Console.WriteLine ("On the road again! We'll see the world and earn {0:F}lv.", 
					secondOfferLeva);
		}
	}
}