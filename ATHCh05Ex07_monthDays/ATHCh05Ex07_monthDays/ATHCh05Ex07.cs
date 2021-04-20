/*
 * Programmer: Tommie
 * Date: 03/30/2021
 * Project: Month Days 
 * Ch: 05 Ex: 07
 */

//DIRECTIVES 
using System;
using static System.Console;

namespace ATHCh05Ex07_monthDays
{
    class ATHCh05Ex07
    {
        static void Main()
        {
            //FIRST TEST
            Month firstTest = new Month(2);
            WriteLine(firstTest.ToString());

            //WAIT FOR USER INPUT | CLEAR SCREEN
            ReadKey();
            Clear();

            //SECOND TEST 
            Month secondTest = new Month();
            secondTest.MonthNum = 6;
            WriteLine(secondTest.ToString());

            //WAIT FOR USER INPUT | CLEAR SCREEN
            ReadKey();
            Clear();

            Month thirdTest = new Month();
            thirdTest.MonthNum = UserInput();
            WriteLine(thirdTest.ToString());

            //WAIT FOR USER INPUT TO EXIT PROGRAM
            ReadKey();
        }

        //METHODS 
        static int UserInput()
        {
            int monthNumber;

            WriteLine("Enter a Month Number (1-12): ");

            if (int.TryParse(ReadLine(), out monthNumber))
            {
                if (monthNumber < 0)
                {
                    WriteLine("Error: Negative Value Entered");
                }
                if (monthNumber > 12)
                {
                    WriteLine("Error: Value Must be Between 1-12");
                }
                if (monthNumber == 0)
                {
                    WriteLine("Error: Value Must be Between 1-12");
                }
            }
            else
            {
                WriteLine("Error: Non-Numeric Value Entered");
            }

            return monthNumber;
        }
    }
}
