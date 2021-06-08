/*
 * Programmer: Tommie
 * Date: 05/02/2021
 * Project: Salesmen Production Report Revised
 * Ch: 08 Ex:03
 */

//DIRECTIVES 
using System;
using static System.Console;

namespace ATHCh08Ex02_Salesmen
{
    class ATHCh08Ex03
    {
        static void Main()
        {
            //VARIABLES
            int[,] salesArray = new int[6, 3];
            string[] salesNames = new string[6] { "Tommy Cartier", "Charlie Mark", "Lilac Uchiha", "Parker Spies", "Austin Cook", "Maddisyn Braun" };
            string[] productList = new string[3] { "Mouses", "Keyboards", "Headsets" };

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

                    while (int.TryParse(inValue, out salesArray[name, product]) == false || salesArray[name, product] < 0)
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
            string[] lastNameSplit = new string[3];
            int maxValue = int.MinValue;
            string maxSalesmen = "";
            string maxProduct = "";

            //CLEAR SCREEN 
            Clear();

            //DISPLAY HEADER 
            Write($"{"Salesmen"}");
            for (int product = 0; product < productList.Length; product++)
            {
                Write($"{productList[product],20} {" ",-1}");
            }
            Write($"{"Total",15}");
            WriteLine();
            WriteLine("+----------------------------------------------------------------------------------------------+");

            //DISPLAY NAMES OF SALESMEN WITH # OF PRODUCTS SOLD
            for (int name = 0; name < salesNames.Length; name++)
            {
                lastNameSplit = salesNames[name].Split(' ');
                Write($"{lastNameSplit[1],9}{" ",-1}:");
                for (int productCount = 0; productCount < salesArray.GetLength(1); productCount++)
                {
                    //STORE SUM OF EACH PRODUCT SOLD FOR EACH SALESMEN INTO ARRAY
                    SumOfSales[name] += salesArray[name, productCount];
                    Write($"{salesArray[name, productCount],14} {" ",7}");
                }
                Write($"{SumOfSales[name],10}");
                WriteLine("\n+----------------------------------------------------------------------------------------------+");
            }

            //GET LARGEST SELL AMOUNT 
            for (int rows = 0; rows < salesArray.GetLength(0); rows++)
            {
                for (int cols = 0; cols < salesArray.GetLength(1); cols++)
                {
                    if (salesArray[rows, cols] > maxValue)
                    {
                        maxValue = salesArray[rows, cols];
                        maxProduct = productList[cols];
                        maxSalesmen = salesNames[rows];
                    }
                }
            }

            //DISPLAY MAX RESULTS 
            WriteLine($"Highest Sell: {maxValue}");
            WriteLine($"Highest Sell Product: {maxProduct}");
            WriteLine($"Sold By: {maxSalesmen}");

            //WAIT FOR USER INPUT TO CLEAR SCREEN AND CLOSE PROGRAM 
            WriteLine("Press Any Key to Exit Program...");
            ReadKey();
            Clear();
        }
    }
}
