
/*
 * Programmer: Tommie
 * Date: 04/02/2021
 * Project: Multiplication Table 
 * Ch: 06 Ex:07
 */

//DIRECTIVES 
using System;
using static System.Console;
using System.Windows.Forms;

namespace ATHCh06Ex07_MultiTable
{
    class ATHCh06Ex07
    {
        static void Main()
        {
            //USER VARIABLES 
            int startingValue,
                endingValue;

            // LOOP VARIABLES
            bool doAgain;

            doAgain = true;
            DisplayInstructions();
            do
            {
                startingValue = GetInput("Enter a Starting Value: ");
                endingValue = GetInput("Enter a Ending Value:");
                DisplayResults(startingValue, endingValue);
                if (MessageBox.Show("Would like to go again?", "Do Again", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    doAgain = false;
                }
                else
                {
                    Clear();
                }
            }
            while (doAgain);
        }

        //METHODS 

        static void DisplayInstructions()
        {
            WriteLine("+------------------------------------------------+");
            WriteLine("Provide the Program with a Starting & Ending Value)");
            WriteLine("Results : Multiplication Table");
            WriteLine("+-------------------------------------------------+");
            WriteLine("Press any key to proceed....");
            ReadKey();
            Clear();
        }

        static int GetInput(string question)
        {
            int userInput;
            string inValue;

            WriteLine(question);
            inValue = ReadLine();

            while (int.TryParse(inValue, out userInput) == false || userInput < 0 || userInput < 2 ||  userInput > 8)
            {
                if (userInput < 0)
                {
                    Clear();
                    WriteLine("Error: Value Must be Positive...");
                    WriteLine(question);
                    inValue = ReadLine();
                }
                else if (int.TryParse(inValue, out userInput) == false)
                {
                    Clear();
                    WriteLine("Error: Value Must be a Number");
                    WriteLine(question);
                    inValue = ReadLine();
                }
                else if (userInput < 2)
                {
                    Clear();
                    WriteLine("Error: Value Must be greater than 2...");
                    WriteLine(question);
                    inValue = ReadLine();
                }
                else if (userInput > 8)
                {
                    Clear();
                    WriteLine("Error: Value Must be less than 8...");
                    WriteLine(question);
                    inValue = ReadLine();
                }
            }

            return userInput;
        }

        static void DisplayResults(int starter, int ending)
        {
            for (int i = starter - 1; i <= ending; i++)
            {
                if (i == starter - 1)
                {
                    Write($"{"n",6}");
                }
                else
                {
                    Write($"{i,6}");
                }
            }
            WriteLine("\n");

            for (int i = 1; i <= 25; i++)
            {
                Write($"{i,6}");
                for (int x = starter; x <= ending; x++)
                {
                    Write($"{i * x,6}");
                }
                WriteLine("");
            }

            ReadKey();
        }
    }
}



