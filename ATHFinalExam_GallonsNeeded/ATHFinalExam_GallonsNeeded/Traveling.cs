/*
 * Programmer: Tommie
 * Date: 05/07/2021
 * File: Traveling.cs
 * Project: Final Exam - Gallons Needed to Travel
 */

//DIRECTIVES 
using System;
using static System.Math;

namespace ATHFinalExam_GallonsNeeded
{
    class Traveling
    {
        //INSTANCE VARIABLES 
        private int
            milesToTravel,
            milesPerGallon;

        private double fuelNeeded;

        //CONSTURCTORS
        public Traveling()
        {
            //DEFAULT CONSTURCTOR
        }

        public Traveling(int milesTraveling, int MPG)
        {
            milesToTravel = milesTraveling;
            milesPerGallon = MPG;
        }

        //PROPERIES 
        public int MilesToTravel
        {
            get { return milesToTravel; }
            set { milesToTravel = value; }
        }
        public int MilesPerGallon
        {
            get { return milesPerGallon; }
            set { milesPerGallon = value; }
        }

        public double FuelNeeded
        {
            get { return fuelNeeded; }
        }


        //INSTANCE METHODS 
        public double CalculateFuel()
        {
            return fuelNeeded = Math.Round(((double)milesToTravel / milesPerGallon));
        }

        public override string ToString()
        {
            return $"You will need approximately {CalculateFuel()} gallons of fuel to travel {milesToTravel} miles at {milesPerGallon} MPG. ";
        }
    }
}
