/*
 * Programmer: Tommie
 * Date: 05/05/2021
 * Project: Magazine Code Creator 
 * Ch: 08 Ex:04
 */

//DIRECTIVES
using System;
using static System.Console;

namespace ATHCh08Ex04_MagazineCode
{
    class ATHCh08Ex04
    {
        static void Main()
        {
            //VARAIBLES 
            string
                name,
                birth,
                zip;

            int month = 1;

            //GET USER INPUT
            name = GetName();
            birth = GetBirthDate();
            zip = GetZipcode();
            GetMonthSub(out month);

            //CREATE MAGAZINE OBJECT
            CodeCreator MagezineCode = new CodeCreator(name, birth, zip, month);

            //DISPLAY RESULTS
            WriteLine("+----------------------------------------------------+");
            WriteLine(MagezineCode);
            WriteLine("+----------------------------------------------------+");
        }

        //METHODS 
        static string GetName()
        {
            //LOCAL VARIABLES
            string userValue = "";
            bool hasSpace = false;

            //ASK USER FOR INPUT
            WriteLine("Please Enter First And Last Name Sperated by a Space:");
            userValue = ReadLine();


            //ERROR CHECKING
            while (userValue.Length == 0 || hasSpace == false || userValue == " ")
            {
                if (userValue.Contains(" "))
                {
                    hasSpace = true;
                }

                if (userValue.Length == 0 || userValue == " ")
                {
                    WriteLine("Error: No Value Was Entered....");
                    WriteLine("Please Enter First And Last Name Sperated by a Space:");
                    hasSpace = false;
                    userValue = ReadLine();
                }
                else if (hasSpace == false)
                {
                    WriteLine("Error: You Did Not Include a Space....");
                    WriteLine("Please Enter First And Last Name Sperated by a Space:");
                    hasSpace = false;
                    userValue = ReadLine();
                }
            }

            //CLEAR SCREEN & RETURN VALUE
            Clear();
            return userValue;
        }

        static string GetBirthDate()
        {
            //LOCAL VARIABLES
            string userValue = "";
            bool hasSlashes = false;

            //ASK USER FOR INPUT
            WriteLine("Please Enter Date of Birth: Format:[mm/dd/yyyy]");
            userValue = ReadLine();

            while(userValue.Length == 0 || hasSlashes == false || userValue == " " || userValue.Length != 10)
            {
                if (userValue.Contains("/") || userValue.Contains("\\"))
                {
                    hasSlashes = true;
                }
                if (userValue.Length == 0 || userValue == " ")
                {
                    WriteLine("Error: No Value Was Entered....");
                    WriteLine("Please Enter Date of Birth: Format:[mm/dd/yyyy]");
                    hasSlashes = false;
                    userValue = ReadLine();
                }
                else if (hasSlashes == false)
                {
                    WriteLine("Error: You Did Not Include Slashes....");
                    WriteLine("Please Enter Date of Birth: Format:[mm/dd/yyyy]");
                    hasSlashes = false;
                    userValue = ReadLine();
                }
                else if (userValue.Length != 10)
                {
                    WriteLine("Error: Date Typed Wrong....");
                    WriteLine("Please Enter Date of Birth: Format:[mm/dd/yyyy]");
                    hasSlashes = false;
                    userValue = ReadLine();
                }
            }

            //CLEAR SCREEN & RETURN VALUE
            Clear();
            return userValue;
        }

        static string GetZipcode()
        {
            //LOCAL VARIABLES
            string userValue = "";

            //ASK USER FOR INPUT
            WriteLine("What Is Your Zipcode:");
            userValue = ReadLine();

            while(userValue.Length == 0 || userValue == " ")
            {

                if (userValue.Length == 0 || userValue == " ")
                {
                    WriteLine("Error: No Value Was Entered....");
                    WriteLine("What Is Your Zipcode:");
                    userValue = ReadLine();
                }
            }

            //CLEAR SCREEN & RETURN VALUE
            Clear();
            return userValue;
        }

        static void GetMonthSub(out int monthOfSub)
        {
            string userValue = "";

            //ASK USER FOR INPUT
            WriteLine("What Month Did You Purchase The Subscriptions: Format:[1 - 12]");
            userValue = ReadLine();

            while(int.TryParse(userValue, out monthOfSub) == false || monthOfSub < 0 || monthOfSub > 12)
            {
                if (int.TryParse(userValue, out monthOfSub) == false)
                {
                    WriteLine("Error: Value Non Numeric....");
                    WriteLine("What Month Did You Purchase The Subscriptions: Format:[1 - 12]");
                    userValue = ReadLine();
                }
                else if (monthOfSub < 0 || monthOfSub > 12)
                {
                    WriteLine("Error: Value Not Between 1 & 12....");
                    WriteLine("What Month Did You Purchase The Subscriptions: Format:[1 - 12]");
                    userValue = ReadLine();
                }
            }

            //CLEAR SCREEN & RETURN VALUE
            Clear();
            int.TryParse(userValue, out monthOfSub);
        }
    }
}
