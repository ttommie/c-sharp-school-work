/*
 * Programmer: Tommie
 * Date: 03/02/2021
 * Project: Return Date
 * Ch: 04 Ex: 01
 */

//DIRECTIVES
using System;
using static System.Console;

namespace ATHCh04Ex01_date
{
    class ATHCh04Ex1_dateProgram
    {
        static void Main()
        {
            WriteLine("Test One");

            //TEST ONE 
            Ch04Date dateTestOne = new Ch04Date("June", 01, 2001);

            WriteLine(dateTestOne.MonthName());

            //WAIT FOR USER INPUT AND CLEAR SCREEN 
            ReadKey();
            Clear();

            //TEST TWO 
            WriteLine("Test Two");
            Ch04Date dateTestTwo = new Ch04Date(06, 01, 2001);

            WriteLine(dateTestTwo.ToString());

            //WAIT FOR USER INPUT AND CLEAR SCREEN 
            ReadKey();
            Clear();

            //TEST THREE 
            WriteLine("Test Three");
            Ch04Date dateTestThree = new Ch04Date();
            dateTestThree.Day = 02;
            dateTestThree.Year = 2021;
            dateTestThree.MonthInNumberFormat = 03;
            dateTestThree.MonthInNameFormat = "March";

            WriteLine(dateTestThree.MonthName());
            WriteLine(dateTestThree.ToString());

            //WAIT FOR USER INPUT
            ReadKey();
        }
    }
}
