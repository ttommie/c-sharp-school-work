/*
 * Programmer: Tommie 
 * Date: 05/07/2021
 * File: ATHFinalExam.cs
 * Project: Final Exam - Gallons Needed to Travel
 */

//DIRECTIVES
using System;
using static System.Console;
using System.Threading;

namespace ATHFinalExam_GallonsNeeded
{
    class ATHFinalExam
    {
        static void Main()
        {
            //VARAIBLES 
            int traveling, 
                miles;

            string sendOverride;

            bool doAgain = false;

            //DISPLAY INSTURCTIONS
            DisplayInstructions();

            do
            {
                //GET MILES TRAVELING
                GetMilesTraveling(out traveling);

                // GET MILES PER GALLON
                GetMilesPerGallon(out miles);

                //OBJECT VARIABLES | CONSTURCTORS & PROPERTIES 
                Traveling consturctorTest = new Traveling(traveling, miles);

                //SET STRING TO SEND TO DISPLAY RESULTS METHOD FOR CONSTURCTOR OBJECT
                sendOverride = consturctorTest.ToString();

                //DISPlAY RESULTS 
                DisplayResults(sendOverride);

                //ASK IF THEY WOULD LIKE TO ENTER ANOTHER VALUE
                doAgain = WhileAgain();

                if (doAgain == false)
                {
                    //IF USER ENTERS NO , CLEAR SCREEN
                    Clear();


                }

            } while (doAgain);

            Traveling propertiesTest = new Traveling();
            propertiesTest.MilesToTravel = 543;
            propertiesTest.MilesPerGallon = 21;

            //SET STRING TO SEND TO DISPLAY RESULTS METHOD FOR PROPERTIES OBJECT
            sendOverride = propertiesTest.ToString();

            //DISPLAY PROPERTIES TEST
            WriteLine("Properties Test Object | Miles To Travel: 543 | Miles Per Gallon: 21");
            WriteLine("Press Any Key to See Results...");

            //WAIT FOR USER INPUT TO DISPLAY RESULTS
            ReadKey();

            //DISPLAY RESULTS
            DisplayResults(sendOverride);

            //DISPLAY A GOODBYE MESSAGE TO USER
            WriteLine("GoodBye!");
            System.Threading.Thread.Sleep(2000);

        }

        //METHODS 

        static void DisplayInstructions()
        {
            //DISPLAY INSTURCTIONS
            WriteLine("+----------------------------------------------+");
            WriteLine("Inputs: Miles Traveling & Miles Per Gallon");
            WriteLine("Results: Fuel Needed to Arrive to Destination");
            WriteLine("+----------------------------------------------+");
            WriteLine("Press Any Key to Proceed...");

            //WAIT FOR USER INPUT TO PROCEED
            ReadKey();

            //CLEAR SCREEN AFTER USER PRESSES KEY
            Clear();
        }


        static void GetMilesTraveling(out int traveling)
        {
            //LOCAL VARIABLE
            string userValue = "";

            //ASK QUESTION
            WriteLine("How Many Miles Will You be Traveling:");

            //READ USER INPUT BEFORE LOOP
            userValue = ReadLine();

            //LOOP THROUGH FOR ERROR CHECKING 
            while (int.TryParse(userValue, out traveling) == false || traveling < 0)
            {
                //IF USER ENTERS A NON NUMERIC NUMBER 
                if (int.TryParse(userValue, out traveling) == false)
                {
                    Clear();
                    WriteLine("Error: Non-Numeric Value Entered....");
                    WriteLine("How Many Miles Will You be Traveling:");
                    userValue = ReadLine();
                }
                else if (traveling < 0) //IF USER ENTERS A NEGATIVE NUMBER  
                {
                    Clear();
                    WriteLine("Error: Negative Value Entered....");
                    WriteLine("How Many Miles Will You be Traveling:");
                    userValue = ReadLine();
                }
            }
        }

        static void GetMilesPerGallon(out int miles)
        {
            //LOCAL VARIABLE
            string userValue = "";

            //ASK QUESTION
            WriteLine("How Many Miles do You Get to The Gallon:");

            //READ USER INPUT BEFORE LOOP
            userValue = ReadLine();

            //LOOP THROUGH FOR ERROR CHECKING
            while(int.TryParse(userValue, out miles) == false || miles < 0 || miles < 5 || miles > 75)
            {
                //USER ENTERS A NON NUMERIC NUM
                if (int.TryParse(userValue, out miles) == false)
                {
                    Clear();
                    WriteLine("Error: Non-Numeric Value Entered....");
                    WriteLine("How Many Miles do You Get to The Gallon:");
                    userValue = ReadLine();
                }
                else if (miles < 0) //USER ENTERS A NEGATIVE NUMBER 
                {
                    Clear();
                    WriteLine("Error: Non-Numeric Value Entered....");
                    WriteLine("How Many Miles do You Get to The Gallon:");
                    userValue = ReadLine();
                }
                else if (miles < 5 || miles > 75) //USER ENTERS A OUT OF RANGE NUMBER
                {
                    Clear();
                    WriteLine("Error: Out of Range Value Entered.... Range: 5-75");
                    WriteLine("How Many Miles do You Get to The Gallon:");
                    userValue = ReadLine();
                }
            }
        }

        static void DisplayResults(string strOverride)
        {
            //CLEAR SCREEN TO DISPLAY RESULTS 
            Clear();

            //DISPLAY RESULTS TO USER
            WriteLine("Results");
            WriteLine("+---------------------------------------------------------------------------+");
            WriteLine(strOverride);
            WriteLine("+---------------------------------------------------------------------------+");
            WriteLine("Pres Any Key to Proceed...");

            //WAIT FOR USER INPUT TO PROCEED
            ReadKey();
        }

        static bool WhileAgain()
        {
            //LOCAL VARIABLES 
            bool again = true;
            string userValue;
            
            //ASK QUESTION
            WriteLine("Would You Like to Enter Another Value? [Y/N]: ");
            userValue = ReadLine().ToUpper();

            //ERROR CHECKING IF USER ENTERED Y OR N
            while (userValue != "Y" && userValue != "N")
            {
                Clear();
                WriteLine("Error: Value must be a Y or N....");
                WriteLine("Would You Like to Enter Another Value? [Y/N]: ");
                userValue = ReadLine().ToUpper();
            }

            //SET AGAIN DEPENDING ON USER INPUT
            if (userValue == "Y")
            { again = true; }
            else if (userValue == "N")
            { again = false; }

            //CLEAR SCREEN AFTER ASKING USER 
            Clear();

            return again;
        }

    }
}
