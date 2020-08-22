using System;

namespace TakeCard
{
	/// <summary>
	/// Exercise 9 solution 
	/// </summary>
	class MainClass
	{
		/// <summary>
		/// Demonstrates using custom classes
		/// </summary>
		/// <param name="args">command-line arguments</param>
		public static void Main(string[] args)
		{
			// create a new deck and tell the deck to print itself
			Deck deck = new Deck();
			deck.Print();
			Console.WriteLine();

			// tell the deck to shuffle and print itself
			deck.Shuffle();
			deck.Print();
			Console.WriteLine();

			// take the top card from the deck and print the card rank and suit
			Card card0 = deck.TakeTopCard();
			Console.WriteLine("First Card: " + card0.Rank + " of " + card0.Suit);

			// take the top card from the deck and print the card rank and suit
			Card card1 = deck.TakeTopCard();
			Console.WriteLine("Second Card: " + card1.Rank + " of " + card1.Suit);

			Console.WriteLine();
		}
	}
}
