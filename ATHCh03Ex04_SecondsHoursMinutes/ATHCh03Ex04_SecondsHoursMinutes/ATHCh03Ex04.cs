/*
 * Programmer: Tommie 
 * Date: 02/13/2021
 * Project: Int of Seconds = Hours, Minutes, & Seconds
 * Ch: 03 Ex: 04
 */

//DIRECTIVES 
using System;
using static System.Console;

namespace ATHCh03Ex04_SecondsHoursMinutes
{ 
    class ATHCh03Ex04
    {
        //GLOBAL VARIABLES
        const int NUMBER_OF_SECONDS_IN_HOUR = 3600;
        const int NUMBER_OF_SECONDS_IN_MINUTE = 60;
        static void Main()
        {
            int seconds,
                hours,
                minutes,
                remainingSeconds;

            //GET USER INPUT FOR SECONDS
            seconds = UserInput();
            
            //CALC HOURS
            hours = NumOfHours(seconds);
            //GET REMAINING SECONDS AFTER CONVERTING HOURS
            remainingSeconds = seconds % NUMBER_OF_SECONDS_IN_HOUR;
            //CALC MINUTES
            minutes = NumOfMinutes(remainingSeconds);
            //GET REMAINING SECONDS AFTER CONVERTING HOURS
            remainingSeconds = seconds % NUMBER_OF_SECONDS_IN_MINUTE;

            //DISPLAY RESULTS TO SCREEN
            DisplayResults(seconds, hours, minutes, remainingSeconds);

            //WAIT FOR USER INPUT TO END PROGRAM 
            ReadKey();

        }

        // USER DEFINDED METHODS
        static int UserInput()
        {
            //LOCAL VARIABLES
            string inputValue;
            int seconds;

            //ASK USER THE AMOUNT OF SECONDS THEY WANT TO ENTER
            WriteLine("Number of seconds to convert: ");
            inputValue = ReadLine();
            seconds = int.Parse(inputValue);

            //RETURN AMOUNT OF SECONDS
            return seconds;

        }

        static int NumOfHours(int seconds)
        {
            //RETURN AMOUNT OF HOURS 
            return seconds / NUMBER_OF_SECONDS_IN_HOUR;
        }

        static int NumOfMinutes(int remainingSeconds)
        {
            //RETURN AMOUNT OF MINUTES
            return remainingSeconds / NUMBER_OF_SECONDS_IN_MINUTE;
        }

        static void DisplayResults(int seconds, int hours, int minutes, int remainingSeconds)
        {
            //CLEAR THE SCREEN
            Clear();
            //DISPLAY OUTPUT 
            WriteLine("Total of Hours, Minutes & Seconds\n");
            WriteLine($"{"Starting Seconds:",-12} {seconds,-8}");
            WriteLine($"{"Hours:",-12} {hours,-8}");
            WriteLine($"{"Minutes:",-12} {minutes,-8}");
            WriteLine($"{"Seconds:",-12} {remainingSeconds,-8}");
        }
    }
}
