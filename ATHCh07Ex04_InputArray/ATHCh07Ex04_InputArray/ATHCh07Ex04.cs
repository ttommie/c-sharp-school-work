/*
 * Programmer: Tommie
 * Date: 04/18/2021
 * Project: Array Input
 * Ch: 07 Ex: 04
 */

//DIRECTIVES
using System;
using static System.Console;
namespace ATHCh07Ex04_InputArray
{
    class ATHCh07Ex04
    {
        static void Main()
        {
            //COUNT VARAIBLES 
            int[] validValueCount = new int[11];
            int nanCount = 0;
            int outOfRangeCount = 0;
            bool doAgain;

            //DISPLAY INSTURCTIONS
            DisplayInstructions();

            do
            {
                //ASK ATlEAST ONCE 
                GetInput(ref validValueCount, ref nanCount, ref outOfRangeCount);

                //ASK IF THEY WOULD LIKE TO ENTER ANOTHER VALUE
                doAgain = WhileAgain();

                if (doAgain == false)
                {
                    //IF USER ENTERS NO , CLEAR SCREEN
                    Clear();
                }
               
            } while (doAgain);

            //DISPLAY OUTPUT 
            DisplayResults(validValueCount, nanCount, outOfRangeCount);
        }

        //METHODS 
        static void DisplayInstructions()
        {
            WriteLine("+---------------------------------+");
            WriteLine("Input a Value between 0 - 10...");
            WriteLine("Results:");
            WriteLine("Valid Value Count");
            WriteLine("Non-Numeric Value Count");
            WriteLine("Out of Range Value Count");
            WriteLine("+----------------------------------+");
            WriteLine("Press any key to proceed...");
            ReadKey();
            Clear();
        }

        static void GetInput(ref int[] validValueCount, ref int nanCount, ref int outOfRangeCount)
        {
            //GET VALUE 
            string inValue;
            int idx;

            WriteLine("Enter a Integer Between 0 - 10: ");
            inValue = ReadLine();

            if (int.TryParse(inValue, out idx) == true)
            {
                if (idx < 0 || idx > 10)
                {
                    Clear();
                    WriteLine("Error: Value out of range....");
                    outOfRangeCount += 1;
                }
                else
                {
                    validValueCount[idx] += 1;
                }
            }
            else
            {
                Clear();
                WriteLine("Error: Value is not numeric....");
                nanCount += 1;
            }
        }

        static bool WhileAgain()
        {
            bool again = true;
            string userValue;
            WriteLine("Would You Like to Enter Another Value? [Y/N]: ");
            userValue = ReadLine().ToUpper();

            while(userValue != "Y" && userValue != "N")
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

        static void DisplayResults(int[] validValuesCount, int nanCount, int outOfRangeCount)
        {
            WriteLine("+----------------------------------------------+");
            WriteLine($"{"Count Results",30}");
            WriteLine("+----------------------------------------------+");
            WriteLine($"{"Out of Range Count:",20} {outOfRangeCount,5}");
            WriteLine($"{ "Non Numeric Count:",20} {nanCount,5} ");
            WriteLine("+----------------------------------------------+");

            WriteLine($"{"Valid Value Count",33}");
            WriteLine("+----------------------------------------------+");

            for (int i = 0; i < validValuesCount.Length; i++)
            {
                WriteLine($"{i + ":",20} {validValuesCount[i],5}");
            }
            WriteLine("+----------------------------------------------+");
            WriteLine("Press any key to exit the program...");
            ReadKey();
        }

    }
}
