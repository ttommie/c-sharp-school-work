/*
 * Programmer: Tommie
 * Date: 3/21/2021
 * Project: Array Parallel
 * Ch: 07 Ex: 03
 */

//DIRECTIVES
using System;
using static System.Console;
using static System.Math;
using System.Windows.Forms;

namespace ATHCh07Ex03_ArrayParallel
{
    class Program
    {
        static void Main()
        {
			//ARRAY VARAIBLES
            double[] arrayOne = new double[3] { 2, 7, 3 };
            double[] arrayTwo = new double[2] { 5, 8 };
            double[] arrayThree = new double[Math.Max(arrayOne.Length, arrayTwo.Length)];

			//IF ONE ARRAY IS LARGER THAN THE OTHER, MULTIPLY THE REMAINING INDEX BY 1
			for (int i = 0; i < arrayThree.Length; i++)
			{
				if (i >= arrayOne.Length)
				{
					arrayThree[i] = arrayTwo[i] * 1;
				}
				else if (i >= arrayTwo.Length)
				{
					arrayThree[i] = arrayOne[i] * 1;
				}
				else
				{
					arrayThree[i] = arrayOne[i] * arrayTwo[i];
					//WriteLine($"{arrayOne[i]} x {arrayTwo[i]} = {arrayThree[i]}\n");
					//ReadKey();
				}
			}

			//DISPLAY RESULTS
			DisplayResults(arrayOne, arrayTwo, arrayThree);
		}

		static void DisplayResults(double[] arrayOne, double[] arrayTwo, double[] arrayThree)
        {
			//MESSAGEBOX HEADING
			string caption = "Parallel Array Results";
			//MESSAGEBOX CONTENT
			string message = "Array One * Array Two = Array Three\n";
			//MESSAGEBOX RESULTS
			string results = "";

			for (int i = 0; i < arrayThree.Length; i++)
            {
				if (i >= arrayOne.Length)
				{
					results += $" 1 x {arrayTwo[i]} = {arrayThree[i]}";
				}
				else if (i >= arrayTwo.Length)
                {
					results += $"{arrayOne[i]} x 1 = {arrayThree[i]}";
                }
				else
                {
					results += $"{arrayOne[i]} x {arrayTwo[i]} = {arrayThree[i]}\n";
				}
			}

			//DISPLAY MESSAGEBOX
			MessageBox.Show(message + results, caption, MessageBoxButtons.OK);
		}
    }
}
