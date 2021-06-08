/*
 * Programmer: Tommie
 * Date: 05/02/2021
 * Project: Salesmen Production Report
 * Ch: 08 Ex:02
 */

//DIRECTIVES 
using System;
using static System.Console;

namespace ATHCh08Ex02_Salesmen
{
    class ATHCh08Ex02
    {
        static void Main()
        {
            //VARIABLES
            int[,] salesArray = new int[6, 3];
            string[] salesNames = new string[6] { "Tommy", "Charlie", "Lilac", "Parker", "Austin", "Maddisyn"};
            string[] productList = new string[3] { "Mouses", "Keyboards", "Headsets"};

            //DISPLAY INSTRUCTIONS 
            DisplayInsturctions();

            //GET INPUT 
            GetInput(salesNames, salesArray, productList);

            //DISPLAY RESULTS
            DisplayResults(productList, salesNames, salesArray);
        }

        //METHODS 

        static void DisplayInsturctions()
        {
            WriteLine("+-----------------------------------+");
            WriteLine("|------------Instructions-----------|");
            WriteLine("+-----------------------------------+");
            WriteLine($"|{"Inputs",21}              |");
            WriteLine("+-----------------------------------+");
            WriteLine("|      Salesmen ID    Product       |");
            WriteLine("+-----------------------------------+");
            WriteLine($"|{"Outputs",21}              |");
            WriteLine("+-----------------------------------+");
            WriteLine("|     Total Sales Per Product       |");
            WriteLine("+-----------------------------------+");
            WriteLine("Press Any Key to Proceed...");
            //WAIT FOR USER INPUT TO PROCEED
            ReadKey();
            //CLEAR SCREEN FOR USER
            Clear();
        }

        static void GetInput(string[] salesName, int[,] salesArray, string[] productList)
        {
            string inValue = "";

            //LOOP THROUGH SALESMEN ARRAY
            for (int name = 0; name < salesName.Length; name++)
            {
                //LOOP THROUGH PRODUCTS LIST
                for (int product = 0; product < productList.Length; product++)
                {
                    //ASK USER FOR INPUT
                    WriteLine($"How many {productList[product]} did {salesName[name]} sell:");

                    //READ USER INPUT
                    inValue = ReadLine();

                    while(int.TryParse(inValue, out salesArray[name, product]) == false || salesArray[name, product] < 0)
                    {
                        if (salesArray[name, product] < 0)
                        {
                            //IF NEGATIVE VALUE CLEAR SCREEN AND ASK AGAIN
                            Clear();
                            WriteLine("Error: Value Negative....");
                            WriteLine($"How many {productList[product]} did {salesName[name]} sell: ");
                            inValue = ReadLine();
                        }
                        else if (int.TryParse(inValue, out salesArray[name, product]) == false)
                        {
                            //IF NON NUMERIC CLEAR SCREEN AND ASK THE QUESTION AGAIN
                            Clear();
                            WriteLine("Error: Value Non Numeric....");
                            WriteLine($"How many {productList[product]} did {salesName[name]} sell: ");
                            inValue = ReadLine();
                        }
                    }

                    //SEND VALUE TO DOUBLE ARRAY FOR THE NAME & PRODUCT ASKED
                    int.TryParse(inValue, out salesArray[name, product]);
                }
            }
        }

        static void DisplayResults(string[] productList, string[] salesNames, int[,] salesArray)
        {
            //VARIABLES 
            int[] SumOfSales = new int[6];
            int totalSum = 0;

            //CLEAR SCREEN 
            Clear();

            //DISPLAY HEADER 
            Write($"{"Salesmen"}");
            for (int product = 0; product < productList.Length; product++)
            {
                Write($"{productList[product],20} {" ", -1}");
            }
            WriteLine();
            WriteLine("+---------------------------------------------------------------------------+");

            //DISPLAY NAMES OF SALESMEN WITH # OF PRODUCTS SOLD
            for (int name = 0; name < salesNames.Length; name++)
            {
                Write($"{salesNames[name],9}{" ",-1}:");
                for (int productCount = 0; productCount < salesArray.GetLength(1); productCount++)
                {
                    //STORE SUM OF EACH PRODUCT SOLD FOR EACH SALESMEN INTO ARRAY
                    SumOfSales[name] += salesArray[name, productCount];
                    Write($"{salesArray[name, productCount],14} {" ", 7}");
                }
                WriteLine("\n+---------------------------------------------------------------------------+");
            }

            // GET TOTAL SUM OF EACH SALESMEN TOTAL SALES INTO ONE VARIABLE
            for (int sum = 0; sum < SumOfSales.Length; sum++)
            {
                totalSum += SumOfSales[sum];
            }

            //DISPLAY TOTAL SOLD OVERALL
            Write($"Total Overall Sales: {totalSum}\n");

            //WAIT FOR USER INPUT TO CLEAR SCREEN AND CLOSE PROGRAM 
            ReadKey();
            Clear();
        }
    }
}
