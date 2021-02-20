/* 
 * Programmer: Tommie
 * Date: 02/19/2021
 * Project: Home Owner Property Tax
 * Ch: 03 Ex: 10
 */

//DIRECTIVES
using System;
using static System.Console;

namespace ATHCh03Ex10_propertyTax
{
    class ATHCh03Ex10
    {
        //GLOBAL VARIABLES
        const double INCREASE_PERCENT = 0.027;
        const double TAX_PER_THOUSAND = 10.03;
        const int EXEMPTION_VALUE = 25000;

        static void Main()
        {
            double priorYearAssessedValue,
                increasedValue,
                totalAfterExemption,
                taxesOwed;

            //RETRIEVE PRIOR YEAR VALUE
            priorYearAssessedValue = UserInput();

            //INCREASE TOTAL VALUE 
            increasedValue = IncreasePercent(priorYearAssessedValue);

            //AFTER EXEMPTION VALUE 
            totalAfterExemption = ExemptionTaken(increasedValue);

            //TOTAL TAXES OWED
            taxesOwed = TotalTaxes(totalAfterExemption);

            //DISPLAY RESULTS 
            DisplayResults(priorYearAssessedValue, increasedValue, totalAfterExemption, taxesOwed);

            //WAIT FOR USER INPUT TO EXIT THE PROGRAM
            ReadKey();
        }

        static double UserInput()
        {
            string inputValue;
            double priorYear;

            WriteLine("What was this prior years value: ");
            inputValue = ReadLine();
            priorYear = double.Parse(inputValue);

            return priorYear;
        }

        static double IncreasePercent(double priorYearAssessedValue)
        {
            return priorYearAssessedValue + (priorYearAssessedValue * INCREASE_PERCENT);
        }

        static double ExemptionTaken(double increasedValue)
        {
            return increasedValue - EXEMPTION_VALUE;
        }

        static double TotalTaxes(double totalAfterExemption)
        {
            return TAX_PER_THOUSAND * (totalAfterExemption / 1000);
        }

        static void DisplayResults(double priorYearAssessedValue, double increasedValue, double totalAfterExemption, double taxesOwed)
        {
            //CLEAR THE SCREEN
            Clear();
            //DISPLAY RESULTS
            WriteLine($"---------------------Results--------------------");
            WriteLine($"{"Prior Value:",-12} {priorYearAssessedValue,-8:C}");
            WriteLine($"{"Increase Value:",-12} {INCREASE_PERCENT,-8:P}");
            WriteLine($"{"Current Value:",-12} {increasedValue,-8:C}");
            WriteLine($"{"Exemption:",-12} {EXEMPTION_VALUE,-8:C}");
            WriteLine($"{"Total After Exemption:",-12} {totalAfterExemption,-8:C}");
            WriteLine($"{"Total Taxes Owed:",-12} {taxesOwed,-8:C}");
            WriteLine($"------------------------------------------------");
        }
    }
}
