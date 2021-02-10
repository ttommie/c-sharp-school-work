/*
 * Programmer: Tommie
 * Date: 01/31/2021
 * Project: Number of Change
 * Chapter: 02 Ex: 04
 */

//DIRECTIVES
using System;
using static System.Console;

namespace ATHCh02Ex04_NumberOfChange
{
    class ATHCh02Ex04
    {
        static void Main()
        {
            // ORGINAL AMOUNT OF CHANGE 
            int originalChange = 27;
            // COIN VALUES 
            const int quarterValue = 25;
            const int dimeValue = 10;
            const int nickelValue = 5;

            //QUARTERS CALC
            int totalQuarters = originalChange / quarterValue;
            originalChange %= quarterValue;

            //DIMES CALC
            int totalDimes = originalChange / dimeValue;
            originalChange %= dimeValue;

            //NICKELS CALC
            int totalNickels = originalChange / nickelValue;

            //PENNIES CALC
            int totalPennies = originalChange % nickelValue;

            //TOTAL AMOUNT RECALC
            double totalAmount = (double)((totalQuarters * quarterValue) + 
                (totalDimes * dimeValue) + (totalDimes * nickelValue) + totalPennies) / 100;

            //PRINT ORGINAL CHANGE TO SCREEN
            WriteLine($"Orginal Change: {totalAmount:C}");

            //PRINT ALL CALCULATED CHANGE TO SCREEN
            WriteLine("Total Quarters: " + totalQuarters +
                "\nTotal Dimes: " + totalDimes +
                "\nTotal Nickels: " + totalNickels +
                "\nTotal Pennies: " + totalPennies);

            //WAIT FOR USER INPUT TO EXIT PROGRAM 
            ReadKey();
        }
    }
}

