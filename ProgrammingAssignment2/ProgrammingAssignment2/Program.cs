using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ConsoleCards; Need this at grader 

namespace ProgrammingAssignment2
{
	// IMPORTANT: Only add code in the section
	// indicated below. The code I've provided
	// makes your solution work with the 
	// automated grader on Coursera

	/// <summary>
	/// Programming Assignment 2
	/// </summary>
	class Program
	{
		/// <summary>
		/// Implements Nothing Like Blackjack functionality
		/// </summary>
		/// <param name="args">command-line args</param>
		static void Main(string[] args)
		{
			// loop while there's more input
			string input = Console.ReadLine();
			while (input[0] != 'q')
			{

				// Add your code between this comment
				// and the comment below. You can of
				// course add more space between the
				// comments as needed
			

				// declare a deck variables and create a deck object
				// DON'T SHUFFLE THE DECK
				Deck deck = new Deck();


				// deal 2 cards each to 4 players (deal properly, dealing
				// the first card to each player before dealing the
				// second card to each player)
				Card card_1_for_player_1 = deck.TakeTopCard();
				Card card_1_for_player_2 = deck.TakeTopCard();
				Card card_1_for_player_3 = deck.TakeTopCard();
				Card card_1_for_player_4 = deck.TakeTopCard();

				Card card_2_for_player_1 = deck.TakeTopCard();
				Card card_2_for_player_2 = deck.TakeTopCard();
				Card card_2_for_player_3 = deck.TakeTopCard();
				Card card_2_for_player_4 = deck.TakeTopCard();



				// deal 1 more card to players 2 and 3

				Card card_3_for_player_2 = deck.TakeTopCard();
				Card card_3_for_player_3 = deck.TakeTopCard();



				// flip all the cards over
				card_1_for_player_1.FlipOver();
				card_1_for_player_2.FlipOver();
				card_1_for_player_3.FlipOver();
				card_1_for_player_4.FlipOver();

				card_2_for_player_1.FlipOver();
				card_2_for_player_2.FlipOver();
				card_2_for_player_3.FlipOver();
				card_2_for_player_4.FlipOver();

				card_3_for_player_2.FlipOver();
				card_3_for_player_3.FlipOver();

				// print the cards for player 1
				Console.WriteLine(card_1_for_player_1.Rank + "," + card_1_for_player_1.Suit);
				Console.WriteLine(card_2_for_player_1.Rank + "," + card_2_for_player_1.Suit);

				// print the cards for player 2
				Console.WriteLine(card_1_for_player_2.Rank + "," + card_1_for_player_2.Suit);
				Console.WriteLine(card_2_for_player_2.Rank + "," + card_2_for_player_2.Suit);
				Console.WriteLine(card_3_for_player_2.Rank + "," + card_3_for_player_2.Suit);

				// print the cards for player 3
				Console.WriteLine(card_1_for_player_3.Rank + "," + card_1_for_player_3.Suit);
				Console.WriteLine(card_2_for_player_3.Rank + "," + card_2_for_player_3.Suit);
				Console.WriteLine(card_3_for_player_3.Rank + "," + card_3_for_player_3.Suit);


				// print the cards for player 4
				Console.WriteLine(card_1_for_player_4.Rank + "," + card_1_for_player_4.Suit);
				Console.WriteLine(card_2_for_player_4.Rank + "," + card_2_for_player_4.Suit);

				// Don't add or modify any code below
				// this comment
				input = Console.ReadLine();
			}
		}
	}
}
