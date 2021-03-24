/*
 * Programmer: Aaron Hearne
 * Date: 03/24/2021
 * Project: Roman Num Values
 * Ch: 05 Ex: 01
 */

//DIRECTIVES
using System;
using static System.Console;
namespace ATHCh05Ex01_romanNum
{
    class ATHCh05Ex01
    {
        static void Main()
        {
            int userNumber;

            userNumber = UserInput();
            DisplayAnswer(userNumber);

            //WAIT FOR USER INPUT TO EXIT THE PROGRAM
            ReadKey();
        }

        //METHODS

        public static int UserInput()
        {
            int userValue = 0;

            WriteLine("Type a number between 1 - 10:");

            if (int.TryParse(ReadLine(), out userValue))
            {
                //CHECK FOR NEG NUMBERS 
                if (userValue <= 0)
                {
                    WriteLine(" Error: Negative/Zero Value Entered");
                }
                //CHECK IF VALUE IS LESS THAN 10
                else if (userValue > 10)
                {
                    WriteLine(" Error: Value Must Be Between 1-10");
                }
            }
            else
            {
                //CHECK IF VALUE IS A INT TYPE 
                WriteLine(" Error: Non-Numeric/Non-Int Value Entered");
            }


            return userValue;
        }

        public static void DisplayAnswer(int userValue)
        {
            //Write Result
            WriteLine("+------------------------------------------------+");
            if (userValue == 1)
            {
                WriteLine($" {userValue} Converted to Roman Numeral: I");
            }
            else if (userValue == 2)
            {
                WriteLine($" {userValue} Converted to Roman Numeral: II");
            }
            else if (userValue == 3)
            {
                WriteLine($" {userValue} Converted to Roman Numeral: III");
            }
            else if (userValue == 4)
            {
                WriteLine($" {userValue} Converted to Roman Numeral: IV");
            }
            else if (userValue == 5)
            {
                WriteLine($" {userValue} Converted to Roman Numeral: V");
            }
            else if (userValue == 6)
            {
                WriteLine($" {userValue} Converted to Roman Numeral: VI");
            }
            else if (userValue == 7)
            {
                WriteLine($" {userValue} Converted to Roman Numeral: VII");
            }
            else if (userValue == 8)
            {
                WriteLine($" {userValue} Converted to Roman Numeral: VII");
            }
            else if (userValue == 9)
            {
                WriteLine($" {userValue} Converted to Roman Numeral: IX");
            }
            else if (userValue == 10)
            {
                WriteLine($" {userValue} Converted to Roman Numeral: X");
            }
            else
            {
                WriteLine("\t\t\tError");
            }
            WriteLine("+------------------------------------------------+");
        }
    }
}
