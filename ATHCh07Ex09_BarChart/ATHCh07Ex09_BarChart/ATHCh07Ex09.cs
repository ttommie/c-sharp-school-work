/*
 * Programmer: Tommie
 * Date: 04/23/2021
 * Project: Bar Chart 
 * Ch: 07 Ex: 09
 */

//DIRECTIVES
using System;
using static System.Console;

namespace ATHCh07Ex09_BarChart
{
    class ATHCh07Ex09
    {
        static void Main()
        {
            //ARRAY FOR DATA COUNT 
            int[] dataArray = new int[11];

            //LOOP VARIABLE 
            bool doAgain;

            //DISPLAY INSTRUCTIONS 
            DisplayInstructions();

            do
            {
                //ASK FOR INPUT ATLEAST ONCE 
                GetInput(ref dataArray);

                //ASK IF THEY WOULD LIKE TO ENTER ANOTHER VALUE 
                doAgain = WhileAgain();

                if (doAgain == false)
                {
                    Clear();
                }

            } while (doAgain);

            DisplayResults(ref dataArray);
            
        }

        //METHODS 
        static void DisplayInstructions()
        {
            WriteLine("+-----------------------------------+");
            WriteLine($"|{"Inputs",20}{"|",16}");
            WriteLine("+-----------------------------------+");
            WriteLine("|An Integer Between 1-10            |");
            WriteLine("+-----------------------------------+");
            WriteLine($"|{"Results",20}{"|",16}");
            WriteLine("+-----------------------------------+");
            WriteLine("|A Bar Graph Counting the           |" +
                    "\n|Amount of Each Number Entered      |");
            WriteLine("+-----------------------------------+");
            WriteLine("Press and key to proceed...");
            ReadKey();
            Clear();
        }

        static void GetInput(ref int[] dataArray)
        {
            string inValue;
            int idx;

            WriteLine("Enter a Integer Between 1 - 10: ");
            inValue = ReadLine();

            while (int.TryParse(inValue, out idx) == false || idx < 0 || idx > 10)
            {
                if (idx < 0 || idx > 10)
                {
                    Clear();
                    WriteLine("Error: Value out of range....");
                    WriteLine("Enter a Integer Between 1 - 10: ");
                    inValue = ReadLine();
                }
                else if (int.TryParse(inValue, out idx) == false)
                {
                    Clear();
                    WriteLine("Error: Value is not numeric....");
                    WriteLine("Enter a Integer Between 1 - 10: ");
                    inValue = ReadLine();
                }
            }

            dataArray[idx]++;
        }

        static bool WhileAgain()
        {
            bool again = true;
            string userValue;
            WriteLine("Would You Like to Enter Another Value? [Y/N]: ");
            userValue = ReadLine().ToUpper();

            while (userValue != "Y" && userValue != "N")
            {
                Clear();
                WriteLine("Error: Value must be a Y or N....");
                WriteLine("Would You Like to Enter Another Value? [Y/N]: ");
                userValue = ReadLine().ToUpper();
            }

            if (userValue == "Y")
            {
                again = true;
            }
            else if (userValue == "N")
            {
                again = false;
            }

            //CLEAR SCREEN AFTER ASKING USER 
            Clear();

            return again;
        }

        static void DisplayResults(ref int[] dataArray)
        {
            Clear();
            WriteLine("+---------------------------------------------------+");
            for (int i = 0; i < dataArray.Length; i++)
            {
                WriteLine($"{i}: {new string('*', dataArray[i])}");
            }
            WriteLine("+---------------------------------------------------+");
            WriteLine("Press any key to exit program...");
            ReadKey();
        }
    }
}
