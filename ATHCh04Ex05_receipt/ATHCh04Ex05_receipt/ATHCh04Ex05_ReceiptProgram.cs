/*
 * Programmer: Tommie
 * Date: 03/02/2021
 * Project: Receipt Porject 
 * Ch: 04 Ex: 05
 */

//DIRECTIVES
using System;
using static System.Console;

namespace ATHCh04Ex05_receipt
{
    class ATHCh04Ex05_ReceiptProgram
    {
        static void Main()
        {
            // TEST ONE 
            WriteLine("Test One");

            Ch04Receipt testOne = new Ch04Receipt(1, "03/01/2021", 1, 3, "Blue Jacket", 8.00, 12);

            WriteLine(testOne.ToString());

            //WAIT FOR USER INPUT TO CLEAR SCREEN AND GO TO THE NEXT TEST 
            ReadKey();
            Clear();

            // TEST TWO 
            WriteLine("Test Two");

            Ch04Receipt testTwo = new Ch04Receipt(2, "03/02/2021", 2, "Thomas Green", "477 Studebaker St. Deland, FL 32720", 4, "Red Jacket", 8.00, 40);

            WriteLine(testTwo.ToString());

            //WAIT FOR USER INPUT TO CLEAR SCREEN AND GO TO THE NEXT TEST 
            ReadKey();
            Clear();

            // TEST THREE 
            WriteLine("Test Three");
            Ch04Receipt testThree = new Ch04Receipt();
            testThree.ReceiptNum = 3;
            testThree.DateOfPurchase = "02/01/2021";
            testThree.CustomerNum = 3;
            testThree.CustomerName = "Dean Rich";
            testThree.CustomerAddress = "25 Howard Court Simpsonville, SC 29680";
            testThree.CustomerPhoneNum = "864-228-8444";
            testThree.ItemNum = 5;
            testThree.ItemDesc = "Green Jacket";
            testThree.UnitPrice = 8.00;
            testThree.QuantityPurchased = 120;

            WriteLine(testThree.ToString());

            //WAIT FOR USER INPUT TO EXIT THE PROGRAMS 
            ReadKey();
        }
    }
}

