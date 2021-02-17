/*
 * Promgrammer: Tommie
 * Date: 02/14/2021
 * Project: 15% & 20% Restaurant Charge
 * Ch: 03 Ex:07
 */

//DIRECTIVES 
using System;
using static System.Console;

namespace ATHCh03Ex07_restaurantCharge
{
    class ATHCh03Ex07
    {
        //GLOBAL VARIABLE 
        const double TOTAL_TAX = 0.9;
        const double FIFTEEN_PERCENT_TIP = 0.15;
        const double TWENTY_PERCENT_TIP = 0.20;
        static void Main()
        {
            double restaurantCharge,
                restaurantTaxAdded,
                fifteen,
                twenty;
            
            //GET CHARGE BEFORE TAX
            restaurantCharge = UserInput();

            //CALC TAX & ADD TO CHARGE
            restaurantTaxAdded = RestaurantTax(restaurantCharge);

            //CALC 15% TIP 
            fifteen = FifteenTip(restaurantTaxAdded);

            //CALC 20% TIP
            twenty = TwentyTip(restaurantTaxAdded);

            //DISPLAY OUTPUT 
            DisplayResults(restaurantCharge, restaurantTaxAdded, fifteen, twenty);

            //WAIT FOR USER INPUT TO EXIT PROGRAM
            ReadKey();
        }

        //USER DEFINED METHODS 
        
        static double UserInput()
        {
            //LOCAL VARIABLES 
            string inputValue;
            double restaurantCharge;

            //ASK USER HOW MUCH THE BILL WAS 
            WriteLine("How much was the bill before tax: ");
            inputValue = ReadLine();
            restaurantCharge = double.Parse(inputValue);

            //RETURN AMOUNT OF CHARGE BACK TO MAIN
            return restaurantCharge;
        }

        static double RestaurantTax(double restaurantCharge)
        {
            return restaurantCharge + (restaurantCharge * TOTAL_TAX);
        }

        static double FifteenTip(double restaurantTaxAdded)
        {
            return restaurantTaxAdded * FIFTEEN_PERCENT_TIP;
        }

        static double TwentyTip(double restaurantTaxAdded)
        {
            return restaurantTaxAdded * TWENTY_PERCENT_TIP;
        }

        static void DisplayResults(double restaurantCharge, double restaurantTaxAdded, double fifteen, double twenty)
        {
            //LOCAL VARIABLES 
            double totalFifteen = restaurantTaxAdded + fifteen;
            double totalTwenty = restaurantTaxAdded + twenty;

            //CLEAR SCREEN
            Clear();
            WriteLine("TOTAL CHARGES PLUS TIP CALCULATIONS\n");
            WriteLine($"{"Charge Before Tax:",-8} {restaurantCharge,-12:C}");
            WriteLine($"{"Charge After Tax:",-8} {restaurantTaxAdded,-12:C}");
            WriteLine($"{"15% Tip:",-8} {fifteen,-12:C}");
            WriteLine($"{"20% Tip:",-8} {twenty,-12:C}");
            WriteLine($"{"Total Charge With 15% Tip:",-8} {totalFifteen,-12:C}");
            WriteLine($"{"Total Charge With 20% Tip:",-8} {totalTwenty,-12:C}");
        }
    }
}
