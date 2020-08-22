using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceRoll
{
	/// <summary>
	/// A dice
	/// </summary>
	public class Dice
	{
		#region Fields

		int topSide;
		int numSides;

		#endregion

		#region Constructors

		/// <summary>
		/// Constructor for six-sided die
		/// </summary>
		public Dice() : this(6)
		{
		}

		/// <summary>
		/// Constructor for a dice with the given number of sides
		/// </summary>
		/// <param name="numSides">the number of sides</param>
		public Dice(int numSides)
		{
			this.numSides = numSides;
			topSide = 1;
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets the current top side of the dice
		/// </summary>
		public int TopSide
		{
			get { return topSide; }
		}

		/// <summary>
		/// Gets the number of sides the dice has
		/// </summary>
		public int NumSides
		{
			get { return numSides; }
		}

		#endregion

		#region Public methods

		/// <summary>
		/// Rolls the dice
		/// </summary>
		public void Roll()
		{
			topSide = RandomNumberGenerator.Next(numSides) + 1;
		}

		#endregion
	}
}

