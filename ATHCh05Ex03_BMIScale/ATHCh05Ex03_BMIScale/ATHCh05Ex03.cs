/*
 * Programmer: Tommie
 * Date: 03/25/2021
 * Project: BMI Scale 
 * Ch: 05 Ex: 03
 */

//DIRECTIVES 
using System;
using static System.Console;

namespace ATHCh05Ex03_BMIScale
{
    class ATHCh05Ex03
    {
        static void Main()
        {
            //VARIABLE 
            double bmi;
            //FIRST TEST [METRIC]
            Scale firstTest = new Scale(27.9, 105.4);
            bmi = firstTest.MetricResults();
            DisplayResults(bmi);

            //WAIT FOR USER INPUT TO PROCEED 
            ReadKey();
            Clear();

            //SECOND TEST [ENGLISH]
            Scale secondTest = new Scale();
            secondTest.UserHeightFeet = 5;
            secondTest.UserHeightInches = 4;
            secondTest.UserWeightPounds = 90;
            secondTest.UserWeightOunces = 0;
            bmi = secondTest.EnglishResults();
            DisplayResults(bmi);

            //WAIT FOR USER INPUT TO PROCEED
            ReadKey();
            Clear();

            //THIRD TEST [METRIC]
            Scale thirdTest = new Scale();
            thirdTest.UserWeightKilograms = UserDoubleInput("How many kilograms do you weight: ");
            thirdTest.UserHeightCentimeters = UserDoubleInput("How tall are you in centimeters: ");
            bmi = thirdTest.MetricResults();

            //CLEAR SCREEN OF INPUTS | DISPLAY RESULTS | WAIT FOR USER INPUT TO PROCEED 
            Clear();
            DisplayResults(bmi);
            ReadKey();

            //FORTH TEST
            Scale forthTest = new Scale();
            WriteLine("How tall are you in Feet and Inches?");
            forthTest.UserHeightFeet = UserIntInput("Feet: ");
            forthTest.UserHeightInches = UserIntInput("Inches: ");
            WriteLine("How much do you weight in Pounds and Ounces?");
            forthTest.UserWeightPounds = UserIntInput("Pounds: ");
            forthTest.UserWeightOunces = UserIntInput("Ounces: ");
            bmi = forthTest.EnglishResults();

            //CLEAR SCREEN OF INPUTS | DISPLAY RESULTS | WAIT FOR USER INPUT PROCEED | EXIT PROGRAM 
            Clear();
            DisplayResults(bmi);
            ReadKey();
        }

        //METHODS 
        static int UserIntInput(string question)
        {
            int userValue;

            WriteLine(question);

            if (int.TryParse(ReadLine(), out userValue))
            {
                if (userValue < 0)
                {
                    WriteLine($"Error: {userValue} is Negative");
                }
            }
            else
            {
                WriteLine($"Error: {userValue} is Non-Numeric");
            }

            return userValue;

        }

        static double UserDoubleInput(string question)
        {
            double userValue;

            WriteLine(question);

            if (double.TryParse(ReadLine(), out userValue))
            {
                if (userValue < 0)
                {
                    WriteLine($"Error: {userValue} is Negative");
                }
            }
            else
            {
                WriteLine($"Error: {userValue} is Non-Numeric");
            }

            return userValue;

        }

        static void DisplayResults(double bmi)
        {
            WriteLine("BMI Results");
            WriteLine("+-----------------------------------------------+");
            WriteLine($"BMI: {bmi:F1}");
            if (bmi < 18.5 )
            {
                WriteLine("Weight Status: UnderWeight");
            }
            else if (bmi == 18.5 || bmi <= 24.9 )
            {
                WriteLine("Weight Status: Normal");
            }
            else if (bmi == 25 || bmi <= 29.9)
            {
                WriteLine("Weight Status: Overweight");
            }
            else if (bmi >= 30)
            {
                WriteLine("Weight Status: Obese");
            }
            WriteLine("+-----------------------------------------------+");
        }
    }
}
