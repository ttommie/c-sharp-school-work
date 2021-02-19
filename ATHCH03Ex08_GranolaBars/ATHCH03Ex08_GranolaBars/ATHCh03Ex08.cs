/*
 * Programmer: Tommie
 * Date: 2/19/2021
 * Project: Total Profit From Granola Bar Sales
 * Ch:03 Ex:08
 */

//DIRECTIVES
using System;
using static System.Console;

namespace ATHCH03Ex08_GranolaBars
{
    class ATHCh03Ex08
    {
        //GLOBAL VARIABLES 
        const int BARS_PER_CASE = 12;
        const double STUDENT_GOV_PERCENTAGE = 0.10;

        static void Main()
        {
            //VARIABLES
            int numOfCasesSold,
                numOfBarsSold;

            double salePricePerBar,
                   totalProfit,
                   tenPercentStudentEarnings,
                   tenPercentSubtracted;

            //DISPLAY INSTURCTIONS TO USER
            DisplayInstructions();
            ReadKey();
            Clear();

            //RETRIVE NUMBER OF CASES SOLD 
            numOfCasesSold = NumberOfCases();

            //RETRIVE PRICE OF PER BAR
            salePricePerBar = PricePerBar();

            //RETRIVE NUMBER OF TOTAL BARS SOLD 
            numOfBarsSold = TotalNumberOfBars(numOfCasesSold);

            //RETRIVE TOTAL PROFIT OF SALES 
            totalProfit = SalesProfit(numOfBarsSold, salePricePerBar);

            //RETRIVE TOTAL PERCENTAGE GIVEN TO STUDENT GOV
            tenPercentStudentEarnings = TenPercentEarnings(totalProfit);

            //SUBTRACT 10% FROM TOTAL PROFITS 
            tenPercentSubtracted = TenPercentSubtracted(totalProfit, tenPercentStudentEarnings);

            //DISPLAY RESULTS 
            DisplayResults(numOfCasesSold, numOfBarsSold, salePricePerBar, totalProfit, tenPercentStudentEarnings, tenPercentSubtracted);
        }

        static void DisplayInstructions()
        {
            WriteLine("---------------------------------------------------------------");
            WriteLine("Enter the following questions asked.");
            WriteLine("We will return your total profit & Student Goverment Earnings.");
            WriteLine("Click Enter the Proceed...");
            WriteLine("---------------------------------------------------------------");
        }

        static int NumberOfCases()
        {
            //LOCAL VARIABLES 
            string inputValue;
            int numOfCases;

            WriteLine($"How many cases were sold:");
            inputValue = ReadLine();
            numOfCases = int.Parse(inputValue);

            return numOfCases;
        }

        static double PricePerBar()
        {
            //LOCAL VARIABLES 
            string inputValue;
            double pricePerBar;

            WriteLine($"How many cases were sold:");
            inputValue = ReadLine();
            pricePerBar = double.Parse(inputValue);

            return pricePerBar;
        }

        static int TotalNumberOfBars(int numOfCasesSold)
        {
            return numOfCasesSold * BARS_PER_CASE;
        }

        static double SalesProfit(int numOfBarsSold, double salePricePerBar)
        {
            return salePricePerBar * numOfBarsSold;
        }

        static double TenPercentEarnings(double totalProfit)
        {
            return  totalProfit * STUDENT_GOV_PERCENTAGE;
        }
        static double TenPercentSubtracted(double totalProfit, double tenPercentStudentEarnings)
        {
            return totalProfit- (totalProfit * STUDENT_GOV_PERCENTAGE);
        }

        static void DisplayResults(int numOfCasesSold, int numOfBarsSold, double salePricePerBar, double totalProfit, double tenPercentStudentEarnings, double tenPercentSubtracted)
        {
            //CLEAR SCREEN
            Clear();
            //DISPLAY RESULTS
            WriteLine("SALE RESULTS");
            WriteLine("---------------------------------------------------------------");
            WriteLine($"{"Total Cases Sold:":,-12} {numOfCasesSold,-8}");
            WriteLine($"{"Total Bars Sold:":,-12} {numOfBarsSold,-8}");
            WriteLine($"{"Total Price of Each Bar:":,-12} {salePricePerBar,-8}");
            WriteLine($"{"Total Sales Profit:":,-12} {totalProfit,-8:C}");
            WriteLine($"{"Total Given to Student Government:":,-12} {tenPercentStudentEarnings,-8:C}");
            WriteLine($"{"Total After 10% Taken:":,-12} {tenPercentSubtracted,-8:C}");
            WriteLine("---------------------------------------------------------------");
        }
    }
}
