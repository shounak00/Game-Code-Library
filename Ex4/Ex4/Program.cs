using System;

namespace Ex4
{
	/// <summary>
	/// Exercise 4 Solution
	/// </summary>
	class MainClass
	{

		public static void Main(string[] args)
		{
			// get locations
			Console.Write("Enter altitude at first location:  ");
			int firstAltitude = int.Parse(Console.ReadLine());
			Console.Write("Enter altitude at second location: ");
			int secondAltitude = int.Parse(Console.ReadLine());

			// calculate and print altitude change
			int altitudeChange = secondAltitude - firstAltitude;
			Console.WriteLine();
			Console.WriteLine("Altitude change: " + altitudeChange);

			Console.WriteLine();
		}
	}
}
