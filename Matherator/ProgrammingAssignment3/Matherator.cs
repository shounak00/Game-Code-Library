﻿using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ProgrammingAssignment3

{

	/// <summary>

	/// Provides a variety of numeric methods

	/// </summary>

	public class Matherator

	{

		#region Constructor

		/// <summary>

		/// Constructor

		/// </summary>

		public Matherator()

		{

		}

		#endregion

		#region Methods

		/// <summary>

		/// Prints the numbers from 1 to 10

		/// </summary>

		public void PrintOneToTen()

		{

			for (int i = 1; i <= 10; i++)

			{

				Console.Write(i + " ");

			}
			//Console.WriteLine ();

		}

		/// <summary>

		/// Prints the numbers from m to n

		/// </summary>

		/// <param name="m">m</param>

		/// <param name="n">n</param>

		public void PrintMToN(int m, int n)

		{

			for (int i = m; i <= n; i++)

			{

				Console.Write(i + " ");

			}
			Console.WriteLine ();

		}

		/// <summary>

		/// Returns the tenth even number, with 2 as the first even number

		/// </summary>

		/// <returns>tenth even number</returns>

		public int GetTenthEvenNumber()

		{

			// delete code below; only included so we could compile

			List<int> list = new List<int>();

			for (int i = 2; i <= 2 * 10; i += 2)

			{

				list.Add(i);

			}

			return list[list.Count - 1];

		}

		/// <summary>

		/// Returns the nth even number, with 2 as the first even number

		/// </summary>

		/// <param name="n">n</param>

		/// <returns>nth even number</returns>

		public int GetNthEvenNumber(int n)

		{

			// delete code below; only included so we could compile

			List<int> nthEven = new List<int>();

			for (int i = 2; i <= 2 * n; i += 2)

			{

				nthEven.Add(i);

			}

			return nthEven[nthEven.Count - 1];

		}

		#endregion

	}

}