using System;

namespace DiceRoll
{
	/// <summary>
	/// Exercise 8 solution
	/// </summary>
	class MainClass
	{
		/// <summary>
		/// Demonstrates rolling and using two dice
		/// </summary>
		/// <param name="args">command-line arguments</param>
		public static void Main(string[] args)
		{
			// initialize random number generator
			RandomNumberGenerator.Initialize();

			// create two dice
			Dice dice1 = new Dice();
			Dice dice2 = new Dice();

			// tell the dice to roll themselves
			dice1.Roll();
			dice2.Roll();

			// print the top sides and the sum of the dice
			Console.WriteLine("Dice 1: " + dice1.TopSide);
			Console.WriteLine("Dice 2: " + dice2.TopSide);
			int sum = dice1.TopSide + dice2.TopSide;
			Console.WriteLine("Sum of Dice: " + sum);

			Console.WriteLine();
		}
	}
}
