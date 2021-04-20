/*
 * Programmer: Tommie 
 * Date: 04/06/2021
 * Project: Int Validation Loop
 * Ch: 06 Ex: 01
 */

//DIRECTIVES
using System;
using static System.Console;
using System.Windows.Forms;

namespace ATHCh06Ex01_IntLoop
{
    class ATHCh06Ex01
    {
        static void Main()
        {
            //INT INPUT VARIABLE 
            //int userNum;

            //COUNTER VARIABLE 
            int totalInvalidNum = 0;
            int totalAboveMax = 0;
            int totalNonNumeric = 0;
            int totalValidEntries = 0;
            int totalEntries = 0;

            //REPEAT VARIABLE 
            bool doAgain;

            DisplayInstructions();
            doAgain = true;

            do
            {
                //GET USER INT INPUT
                GetInput(ref totalInvalidNum, ref totalAboveMax, ref totalNonNumeric, ref totalValidEntries);


                if (MessageBox.Show("Would you like to enter another integer?", "Do Again", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    doAgain = false;
                }
                else
                {
                    Clear();
                }

            } while (doAgain);

            //CALCULATE TOTAL INVALID COUNT AND TOTAL ENTRIES 
            totalInvalidNum += totalAboveMax + totalNonNumeric;

            totalEntries = totalInvalidNum + totalValidEntries;

            //DISPLAY RESULTS 
            DisplayResults(totalInvalidNum, totalAboveMax, totalNonNumeric, totalValidEntries, totalEntries);
        }

        //METHODS 

        static void DisplayInstructions()
        {
            WriteLine("+-------------------------------------------+");
            WriteLine("Enter a Integer");
            WriteLine("Rules:\nMust be a Integer.\nMust be Positive.\nMust be Between 0 & 100.");
            WriteLine("+-------------------------------------------+");
            WriteLine("Press Any Key to Proceed....");

        }

        static int GetInput(ref int totalInvalidNum, ref int totalAboveMax, ref int totalNonNumeric, ref int totalValidEntries)
        {
            //GET VALUE
            int userValue = 0;
            string inValue;

            Clear();
            WriteLine("Please Enter An Integer: ");
            inValue = ReadLine(); //INTO (PRIME) READ BEFORE LOOP

            //INPUT VALIDATION LOOP
            while ((int.TryParse(inValue, out userValue) == false) || userValue < 0 || userValue > 100)
            {
               if (userValue < 0)
                {
                    Clear();
                    WriteLine("Value Must be Greater Than 0");
                    WriteLine("Please Enter An Integer: ");
                    inValue = ReadLine();
                    totalInvalidNum += 1;
                    
                }
               else if(userValue > 100)
                {
                    Clear();
                    WriteLine("Value Must be Less Than 100");
                    WriteLine("Please Enter An Integer: ");
                    inValue = ReadLine();
                    totalAboveMax += 1;
                }
               else if (int.TryParse(inValue, out userValue) == false)
                {
                    Clear();
                    WriteLine("Value Must be An Numeric Value");
                    WriteLine("Please Enter An Integer: ");
                    inValue = ReadLine();
                    totalNonNumeric += 1;
                }
            }

            totalValidEntries += 1;

            return userValue;
        }

        static void DisplayResults(int totalInvalidNum, int totalAboveMax, int totalNonNumeric, int totalValidEntries, int totalEntries)
        {
            WriteLine("+-------------------------------------------+");
            WriteLine($"{"Results",25}");
            WriteLine($"{"Total Entires: ",15} {totalEntries}");
            WriteLine($"{"Total Valid Entires: ",15} {totalValidEntries}");
            WriteLine($"{"Total Invalid Entries: ",15} {totalInvalidNum}");
            WriteLine($"{"Total Above Max: ",15} {totalAboveMax}");
            WriteLine($"{"Total Non numeric: ",15} {totalNonNumeric}");
            WriteLine("+-------------------------------------------+");
            ReadKey();
        }

    }
}
