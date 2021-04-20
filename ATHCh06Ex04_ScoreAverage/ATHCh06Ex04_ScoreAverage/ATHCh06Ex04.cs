/*
 * Programmer: Tommie
 * Date: 04/07/2021
 * Project: Score Average
 * Ch: 06 Ex: 04
 */

//DIRECTIVES
using System;
using static System.Console;
using System.Windows.Forms;

namespace ATHCh06Ex04_ScoreAverage
{
    class ATHCh06Ex04
    {
        static void Main()
        {
            //USER INPUT 
            double scoreInput;

            //CALC VARAIBLES 
            int scoreCount = 0;
            double
                scoreTotal = 0,
                scoreAverage;

            //LOOP VARIABLES 
            bool doAgain;

            doAgain = true;
            DisplayInstructions();
            do
            {
                scoreInput = GetInput(ref scoreCount);
                scoreTotal += scoreInput;

                if (MessageBox.Show("Would you like to enter another grade?", "Do Again", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    doAgain = false;
                }
                else
                {
                    Clear();
                }

            } while (doAgain);

            //CALCULATE AVERAGE 
            scoreAverage = scoreTotal / scoreCount;

            //DISPLAY RESULTS
            DisplayResults(scoreCount, scoreAverage);
        }

        //METHODS 

        static void DisplayInstructions()
        {
            WriteLine("+----------------------------------------------+");
            WriteLine("Input Each Score");
            WriteLine("Results: Score Average & Letter Grade");
            WriteLine("+----------------------------------------------+");
            WriteLine("Press any key to proceed....");
            ReadKey();
            Clear();
        }


        static double GetInput(ref int scoreCount)
        {
            double userValue = 0;
            string inValue;

            WriteLine("Please Enter A Score: ");
            inValue = ReadLine(); //INTO (PRIME) READ BEFORE LOOP

            //INPUT VALIDATION LOOP
            while ((double.TryParse(inValue, out userValue) == false) || userValue < 0 || userValue > 100)
            {
                if (userValue < 0)
                {
                    Clear();
                    WriteLine("Value Must be Greater Than 0");
                    WriteLine("Please Enter A Grade: ");
                    inValue = ReadLine();
                }
                else if (userValue > 100)
                {
                    Clear();
                    WriteLine("Value Must be Less Than 100");
                    WriteLine("Please Enter A Grade: ");
                    inValue = ReadLine();
                }
                else if (double.TryParse(inValue, out userValue) == false)
                {
                    Clear();
                    WriteLine("Value Must be An Numeric Value");
                    WriteLine("Please Enter A Grade: ");
                    inValue = ReadLine();
                }
            }

            scoreCount += 1;
            return userValue;
        }

        static void DisplayResults(int scoreCount, double scoreAverage)
        {
            //CLEAR SCREEN
            Clear();
            WriteLine("+----------------------------------------+");
            WriteLine($"{"Results",30}");
            WriteLine($"{"Total Scores:",15} {scoreCount,20}");
            WriteLine($"{"Total Average:",15} {scoreAverage,20:F2}");
            if (scoreAverage > 90 || scoreAverage < 100)
            {
                WriteLine($"{"Letter Grade:",15} {"A",20}");
            }
            else if (scoreAverage > 80 || scoreAverage < 89)
            {
                WriteLine($"{"Letter Grade:",15} {"B",20}");

            }
            else if (scoreAverage > 70 || scoreAverage < 79)
            {
                WriteLine($"{"Letter Grade:",15} {"C",20}");

            }
            else if (scoreAverage > 60 || scoreAverage < 69)
            {
                WriteLine($"{"Letter Grade:",15} {"D",20}");

            }
            else if (scoreAverage < 60)
            {
                WriteLine($"{"Letter Grade:",15} {"F",20}");

            }
            WriteLine("+----------------------------------------+");
            WriteLine("Press any key to exit program....");
            ReadKey();

        }
    }
}
