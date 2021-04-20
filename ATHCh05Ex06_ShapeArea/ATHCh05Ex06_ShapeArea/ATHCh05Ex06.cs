/*
 * Programmer: Tommie
 * Date: 03/29/2021
 * Project: Shape Area 
 * Ch: 05 Ex: 06
 */

//DIRECTIVES
using System;
using static System.Console;
using static System.Math;

namespace ATHCh05Ex06_ShapeArea
{
    class ATHCh05Ex06
    {
        static void Main()
        {
            //SELECTION VARIABLE 
            string userShape;

            //CIRCLE RETURN
            double circleResults = 0;

            //RECTANGLE RETURN
            double rectangleResults = 0;

            //CYLINDER RETURN
            double cylinderResults = 0;

            userShape = ShapeSelection();

            if (userShape == "CIRCLE")
            {
                circleResults = CircleCalc();
            }
            else if (userShape == "RECTANGLE")
            {
                rectangleResults = RectangleCalc();
            }
            else if (userShape == "CYLINDER")
            {
                cylinderResults = CylinderCalc();
            }
            else
            {
                WriteLine($"Error : {userShape.ToLower()} is not an option...");
            }

            //DISPLAY RESULTS
            DisplayResults(userShape, circleResults, rectangleResults, cylinderResults);

            //WAIT FOR USER INPUT TO EXIT PROGRAM
            ReadKey();
        }

        //METHODS
        static string ShapeSelection()
        {
            string userValue;
            WriteLine("Select A Shape: Circle/Rectangle/Cylinder ");
            userValue = ReadLine().ToUpper();

            return userValue;
        }

        static double CircleCalc()
        {
            //VARIABLE 
            double 
                cirRadius,
                cirResults = 0;

            WriteLine("What is the radius of the circle: ");

            if (double.TryParse(ReadLine(), out cirRadius))
            {
                if(cirRadius > 0)
                {
                    cirResults = Math.PI * Math.Sqrt(cirRadius);
                }
                else if (cirRadius < 0)
                {
                    WriteLine("Error: Negative Value Entered");
                }
            }
            else
            {
                WriteLine("Error: Non-Numeric Value Entered");
            }

            return cirResults;
        }

        static double RectangleCalc()
        {
            //VARIABLE 
            double
                recLength = 0,
                recWidth = 0,
                recResults = 0;

            WriteLine("What is length of the rectangle: ");

            if (double.TryParse(ReadLine(), out recLength))
            {
                if (recLength < 0)
                {
                    WriteLine("Error: Negative Value Entered");
                }
            }
            else
            {
                WriteLine("Error: Non-Numeric Value Entered");
            }

            if (recLength > 0)
            {
                WriteLine("What is width of the rectangle: ");

                if (double.TryParse(ReadLine(), out recWidth))
                {
                    if (recWidth < 0)
                    {
                        WriteLine("Error: Negative Value Entered");
                    }
                }
                else
                {
                    WriteLine("Error: Non-Numeric Value Entered");
                }

                if (recLength > 0 && recWidth > 0)
                {
                    recResults = recLength * recWidth;
                }
                else
                {
                    Clear();
                    WriteLine("Error: Cannot Calculate Values");
                }
            }
            return recResults;
        }

        static double CylinderCalc()
        {
            //VARIABLE 
            double
                cylRadius = 0,
                cylHeight = 0,
                cylResults = 0;

            WriteLine("What is height of the cylinder: ");

            if (double.TryParse(ReadLine(), out cylHeight))
            {
                if (cylHeight < 0)
                {
                    WriteLine("Error: Negative Value Entered");
                }
            }
            else
            {
                WriteLine("Error: Non-Numeric Value Entered");
            }

            if (cylHeight > 0)
            {
                WriteLine("What is radius of the cylinder: ");

                if (double.TryParse(ReadLine(), out cylRadius))
                {
                    if (cylRadius < 0)
                    {
                        WriteLine("Error: Negative Value Entered");
                    }
                }
                else
                {
                    WriteLine("Error: Non-Numeric Value Entered");
                }

                if (cylHeight > 0 && cylRadius > 0)
                {
                    cylResults = 2 * Math.PI * cylRadius * cylHeight + 2 * Math.PI * Math.Sqrt(cylRadius);
                }
                else
                {
                    Clear();
                    WriteLine("Error: Cannot Calculate Values");
                }
            }
            return cylResults;
        }

        static void DisplayResults(string shapeSelect, double cirResults, double recResults, double cylResults)
        {
            //CLEAR THE SCREEN
            Clear();
            WriteLine("+--------------------------------------------------------+");
            if (shapeSelect == "CIRCLE")
            {
                WriteLine("Shape: Circle Results");
                WriteLine($"The Area: {cirResults:F2}");
            }
            else if (shapeSelect == "RECTANGLE")
            {
                WriteLine("Shape: Rectangle Results");
                WriteLine($"The Area: {recResults:F2}");
            }
            else if (shapeSelect == "CYLINDER")
            {
                WriteLine("Shape: Cylinder Results");
                WriteLine($"The Area: {cylResults:f2}");
            }
            WriteLine("+--------------------------------------------------------+");
        }
    }
}
