/*
 * Programmer: Tommie
 * Date: 2/13/2021
 * Project: Rectangle Calculation
 * Ch: 03 Ex: 03
 */

//DIRECTIVES
using System;
using static System.Console;

namespace ATHCh03Ex03_rectangleCalc
{
    class ATHCh03Ex03
    {
        //GLOBAL DELCARATION 
        const int INCHES_IN_FT = 12;

        static void Main()
        {
            double length,
                   width,
                   area,
                   perimeter;

            //USER INPUT TO RETRIEVE FEET & INCHES
            length = GetInput("length");
            width = GetInput("width");

            //RECTANGLE CALCULATIONS
            area = CalcArea(length, width);
            perimeter = CalcPerimeter(length, width);

            //DISPLAY OUTPUT TO SCREEN
            DisplayOuput(length, width, area, perimeter);

            //WAIT FOR USER INPUT TO END PROGRAM 
            ReadKey();
        }

        //USER DEFINDED METHODS
        public static double GetInput(string side)
        {
            //LOCAL VARAIBLES
            string inputValue;
            int feet,
                inches;

            //ASK USER TO ENTER FEET AND INCHES FOR LENGTH & WIDTH
            WriteLine($"Enter the {side} in feet: ");
            inputValue = ReadLine();
            feet = int.Parse(inputValue);
            WriteLine($"Enter the {side} in inches: ");
            inputValue = ReadLine();
            inches = int.Parse(inputValue);

            //RETURN FEET + INCHES AS DOUBLE 
            return (feet + ((double)inches / INCHES_IN_FT));
        }

        static double CalcArea(double length, double width)
        {
            //RETURN AREA TO MAIN
            return length * width;
        }

        static double CalcPerimeter(double length, double width)
        {
            //RETURN PERIMETER TO MAIN
            return 2 * (length + width);
        }

        static void DisplayOuput(double length, double width, double area, double perimeter)
        {
            //CLEAR THE SCREEN
            Clear();
            //DISPLAY ALL CALCS
            WriteLine("Summary of Rectangle Measurements\n");
            WriteLine($"{"Length:",-12} {length,8:N1}");
            WriteLine($"{"Width:",-12} {width,8:N1}");
            WriteLine($"{"Area:",-12} {area,8:N1}");
            WriteLine($"{"Perimeter:",-12} {perimeter,8:N1}");
        }
    }
}
