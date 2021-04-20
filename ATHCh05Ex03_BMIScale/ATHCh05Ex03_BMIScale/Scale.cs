/*
 * Programmer: Tommie
 * Date: 03/28/2021
 * File: Scale.cs
 * Instance Variables : Weight Pounds/Ounces | Height Feet/Inches | Weight Kilograms | Height Centimeters
 */

using System;
using static System.Math;


namespace ATHCh05Ex03_BMIScale
{
    class Scale
    {
        //ENGLISH SCALE INSTANCE VARIABLES 

        private int
            userWeightPounds,
            userWeightOunces,
            userHeightFeet,
            userHeightInches;

        //METRIC SCALE INSTANCE VARIABLES 
        private double
            userWeightKilograms,
            userHeightCentimeters;


        //CONSTURCTORS 

        public Scale()
        {

        }

        public Scale(int heightFeet, int heightInches,int pounds, int ounces)
        {
            userHeightFeet = heightFeet;
            userHeightInches = heightInches;
            userWeightPounds = pounds;
            userWeightOunces = ounces;
        }

        public Scale(double weightKilo, double heightCent)
        {
            userWeightKilograms = weightKilo;
            userHeightCentimeters = heightCent;
        }

        //PROPERTIES 

        public int UserWeightPounds
        {
            get
            {
                return userWeightPounds;
            }
            set
            {
                userWeightPounds = value;
            }
        }

        public int UserWeightOunces
        {
            get
            {
                return userWeightOunces;
            }
            set
            {
                userWeightOunces = value;
            }
        }

        public int UserHeightFeet
        {
            get
            {
                return userHeightFeet;
            }
            set
            {
                userHeightFeet = value;
            }
        }

        public int UserHeightInches
        {
            get
            {
                return userHeightInches;
            }
            set
            {
                userHeightInches = value;
            }
        }

        public double UserWeightKilograms
        {
            get
            {
                return userWeightKilograms;
            }
            set
            {
                userWeightKilograms = value;
            }
        }

        public double UserHeightCentimeters
        {
            get
            {
                return userHeightCentimeters;
            }
            set
            {
                userHeightCentimeters = value;
            }
        }

        //METHODS 

        public double EnglishResults()
        {
            double userTotalWeight = userWeightPounds + (userWeightOunces / 16);
            double userTotalHeight = (userHeightFeet * 12) + userHeightInches;

            double userBMIResults = (userTotalWeight / (userTotalHeight * userTotalHeight)) * 703;

            return userBMIResults;
        }

        public double MetricResults()
        {
            double userBMIResults = (userWeightKilograms / (userHeightCentimeters * userHeightCentimeters)) * 10000;

            return userBMIResults;
        }
    }
}
