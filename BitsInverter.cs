﻿using System;

class BitsInverter
{
	public static void Main (string[] args)
	{
		int n = int.Parse (Console.ReadLine());
		int step = int.Parse (Console.ReadLine());
		int index = 0;

		for (int i = 0; i < n; i++) {
			int number = int.Parse (Console.ReadLine());
			for (int bit = 7; bit > 0; bit--) {
				index++;
				if ((step == 1) || (index % step == 1)) {
					number = number ^ (1 << bit);
				}
			}
			Console.WriteLine (number);
		}
	}
}