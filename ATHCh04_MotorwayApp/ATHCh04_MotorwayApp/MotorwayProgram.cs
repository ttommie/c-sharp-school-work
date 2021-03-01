/*
 * Programmer: Tommie
 * Date: 03/01/2021
 * Project: Motorway Application
 * Chapter: 04
 */

//DIRECTIVES
using System;
using static System.Console;

namespace ATHCh04_MotorwayApp
{
    class MotorwayProgram
    {
        static void Main()
        {
            Motorway mwObject; //DECLARE BUT NOT INSTANTIATED (NO OBJECT CREATED YET)

            //VARIABLES
            string nameOfMW,
                typeOfMW,
                surfaceOfMW,
                mntcePartyForMW;
            int lanesforMW;

            //FIRST OBJECT
            Motorway hwy401 = new Motorway("HWY 401", "Arterial", "Asphalt", 4, "State");
            hwy401.Toll = false;
            hwy401.Direction = "North/South";
            WriteLine("First Test\n" + hwy401 + "\n"); //NOTICE OBJECT hwy401 IN WRITELINE CAUSES TOSTRING() METHOD TO EXECUTE

            //SECOND OBJECT
            Motorway secondTest = new Motorway();
            secondTest.NameOfMotorway = "College Circle";
            secondTest.TypeOfMotorway = "Local";
            secondTest.MntceParty = "Private";
            secondTest.Direction = " ";
            secondTest.Toll = false;
            secondTest.Surface = "Asphalt";
            WriteLine("Second Test\n" + secondTest + "\n"); //NOTICE OBJECT secondTest IN WRITELINE CAUSES TOSTRING() METHOD TO EXECUTE

            //THIRD OBJECT 
            Motorway thirdTest = new Motorway();
            WriteLine("Third Test - No Values Assigned");
            //NOTICE USE OF PROPERTIES OF OBJECT
            WriteLine("Motorway Test 3: " + thirdTest.NameOfMotorway + " " +
                thirdTest.TypeOfMotorway + " " + thirdTest.Direction + " " +
                "\nLanes: " + thirdTest.NumberOfLanes +
                "\nTolls: " + thirdTest.Toll +
                "\nMaintained By: " + thirdTest.MntceParty);

            //CLEAR SCREEN OF PAST TEST
            ReadKey();
            Clear(); 

            //ASK FOR DATA AND ASSIGN TO VARIABLES
            nameOfMW = GetStrInput("Enter Name of Motorway: ");
            typeOfMW = GetStrInput("Enter Type of Motorway: ");
            surfaceOfMW = GetStrInput("Enter Surface of Motorway: ");
            lanesforMW = GetIntInput("Enter Number of Lanes for Motorway: ");
            mntcePartyForMW = GetStrInput("Enter Maintenance Party of Motorway: ");

            //CREATE (INSTANTIATE) mwObject WITH INTIAL VALUES USING INPUT VARIABLES
            mwObject = new Motorway(nameOfMW, typeOfMW, surfaceOfMW, lanesforMW, mntcePartyForMW);

            //SET PROPERTIES AFTER CREATION
            mwObject.Toll = false;
            mwObject.Direction = " ";

            WriteLine(); //BLANK LINE
            WriteLine($"Motorway mwObject \n Name:" + mwObject.GetFullName() +
                $"\nSurface: {mwObject.Surface} \nNumber of Lanes: {mwObject.NumberOfLanes}" +
                $"\nToll: {mwObject.Toll} \nMaintenance: {mwObject.MntceParty} ");

            WriteLine(mwObject.GetLaneInformation());


            //WAIT FOR USER INPUT TO EXIT THE PROGRAM
            ReadKey();
        }

        public static int GetIntInput(string prompt)
        {
            //LOCAL VARIABLES 
            string inputValue;
            int intValue;

            Write($"{prompt}");
            inputValue = ReadLine();
            intValue = int.Parse(inputValue);

            return intValue;
        }

        public static string GetStrInput(string prompt)
        {
            //LOCAL VARIABLES 
            string inputValue;

            Write($"{prompt}");
            inputValue = ReadLine();

            return inputValue;
        }
    }
}
