/*
 * Programmer: Tommie
 * Date: 04/11/2021
 * Project: GPA Calculator 
 * Ch: 06 Ex: 10
 */

//DIRECTIVES
using System;
using static System.Console;
using System.Windows.Forms;

namespace ATHCh06Ex10_gpaCalculator
{
    class Program
    {
        //GLOBALS 
        const int 
            LETTER_A = 4,
            LETTER_B = 3,
            LETTER_C = 2,
            LETTER_D = 1;

        static void Main()
        {
            //USER INPUT VARIABLES 
            string letterGrade;
            int numOfCredHours;

            //CALC VARIABLES 
            int totalCreditHours = 0;
            int totalCoursePoints = 0;
            int coursePoint = 0;
            double gpaTotal;

            //LOOP VARIABLE
            bool doAgain;

            DisplayInstructions();
            doAgain = true;
            do
            {
                letterGrade = GetLetterGrade();
                numOfCredHours = GetCreditHours();
                totalCreditHours += numOfCredHours;

                if (letterGrade == "A")
                {
                    coursePoint = numOfCredHours * LETTER_A;
                }
                else if (letterGrade == "B")
                {
                    coursePoint = numOfCredHours * LETTER_B;
                }
                else if (letterGrade == "C")
                {
                    coursePoint = numOfCredHours * LETTER_C;
                }
                else if (letterGrade == "D")
                {
                    coursePoint = numOfCredHours * LETTER_D;
                }

                totalCoursePoints += coursePoint;

                if (MessageBox.Show("Would you like to enter another grade?", "Do Again", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    doAgain = false;
                }
                else
                {
                    Clear();
                }
            }
            while (doAgain);

            gpaTotal = (double)totalCoursePoints / totalCreditHours;
            DisplayResults(totalCoursePoints, totalCreditHours, gpaTotal);
        }

        //METHODS 

        static void DisplayInstructions()
        {
            WriteLine("+----------------------------------------------------+");
            WriteLine("User Instructions: Input Letter Grade & Credit Hours");
            WriteLine("-------------------------Results---------------------" +
                        $"\n{"Calculated GPA",35}" +
                        $"\n{"Total Credit Hours",37}" +
                        $"\n{"Total Course Points",38}");
            WriteLine("+----------------------------------------------------+");
            WriteLine("Press Any Key to Proceed...");
            ReadKey();
            Clear();
        }

        static string GetLetterGrade()
        {
            string userValue;

            WriteLine("Input a Letter Grade: [A | B | C | D] ");
            userValue = ReadLine().ToUpper();

            while (userValue != "A" && userValue != "B" && userValue != "C" && userValue != "D")
            {
                    Clear();
                    WriteLine("Error: Value must be an A, B, C, or D....");
                    WriteLine("Input a Letter Grade: [A | B | C | D] ");
                    userValue = ReadLine();
            }

            return userValue;
        }

        static int GetCreditHours()
        {
            int userValue;
            string inValue;

            WriteLine("Input Credit Hours:");
            inValue = ReadLine();

            while(int.TryParse(inValue, out userValue) == false || userValue < 0)
            {
                if(userValue < 0)
                {
                    Clear();
                    WriteLine("Error: Value Must be Positive....");
                    WriteLine("Input Credit Hours:");
                    inValue = ReadLine();
                }
                else if (int.TryParse(inValue, out userValue) == false)
                {
                    Clear();
                    WriteLine("Error: Value Must be Number....");
                    WriteLine("Input Credit Hours:");
                    inValue = ReadLine();
                }
            }

            return userValue;
        }

        static void DisplayResults(int totalCredits, int totalHours, double gpa)
        {
            WriteLine("+-----------------------Results----------------------+");
            WriteLine($"{"Total Course Credits:"} {totalCredits}");
            WriteLine($"{"Total Credit Hours:"} {totalHours,3}");
            WriteLine($"{"Student GPA:"} {gpa,13:F2}");
            WriteLine("+----------------------------------------------------+");
            WriteLine("Press Any Key to Exit The Program...");
            ReadKey();
        }
    }
}
