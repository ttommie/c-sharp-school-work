/*
 * Programmer: Tommie
 * Date: 05/05/2021
 * File: CodeCreator.cs
 * Private Variables: Fullname | Date of Birth | Zipcode | Month of Subscription
 */

//DIRECTIVES
using System;


namespace ATHCh08Ex04_MagazineCode
{
    class CodeCreator
    {
        //PRIVATE VARIABLES 
        private string
            fullname,
            dateOfBirth,
            zipcode;

        private int
            monthOfSub;

        //CONSTRUCTORS 
        public CodeCreator()
        {
            //DEFAULT CONSTRUCTOR
        }

        public CodeCreator(string name, string birthday, string zip, int monthSub)
        {
            fullname = name;
            dateOfBirth = birthday;
            zipcode = zip;
            monthOfSub = monthSub;
        }

        //PROPERTIES 
        public string Fullname
        {
            get
            {
                return fullname;
            }
            set
            {
                fullname = value;
            }
        }

        public string DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
            }
        }

        public int MonthOfSub
        {
            get
            {
                return monthOfSub;
            }
            set
            {
                monthOfSub = value;
            }
        }

        public string Zipcode
        {
            get
            {
                return zipcode;
            }
            set
            {
                zipcode = value;
            }
        }

        //METHODS
        public string FullnameSplit()
        {
            //LOCAL VARIABLES
            string[] fullNameArray = new string[3];
            string lastName = "";

            //SPLIT NAME INTO ARRAY
            fullNameArray = fullname.Split(' ');

            // RETURN LAST NAME
            return lastName = fullNameArray[1];
        }

        public string BirthSubString()
        {
            //LOCAL VARIABLES
            string birthYear = "";

            //SUB STRING LAST TWO DIGITS OF YEAR 
            birthYear = dateOfBirth.Substring(dateOfBirth.Length - 2);

            //RETURN LAST TWO DIGITS
            return birthYear;
        }

        public string MonthName()
        {
            //LOCAL VARIABLES
            string nameOfMonth = "";

            //CHECK 1 - 12 AND ASSIGN MONTH NAME TO VARIABLE
            if (monthOfSub == 1)
            {
                nameOfMonth = "Jan";
            }
            else if (monthOfSub == 2)
            {
                nameOfMonth = "Feb";
            }
            else if (monthOfSub == 3)
            {
                nameOfMonth = "Mar";
            }
            else if (monthOfSub == 4)
            {
                nameOfMonth = "Apr";
            }
            else if (monthOfSub == 5)
            {
                nameOfMonth = "May";
            }
            else if (monthOfSub == 6)
            {
                nameOfMonth = "Jun";
            }
            else if (monthOfSub == 7)
            {
                nameOfMonth = "Jul";
            }
            else if (monthOfSub == 88)
            {
                nameOfMonth = "Aug";
            }
            else if (monthOfSub == 9)
            {
                nameOfMonth = "Sep";
            }
            else if (monthOfSub == 10)
            {
                nameOfMonth = "Oct";
            }
            else if (monthOfSub == 11)
            {
                nameOfMonth = "Nov";
            }
            else if (monthOfSub == 12)
            {
                nameOfMonth = "Dec";
            }

            //RETURN NAME OF MONTH
            return nameOfMonth;
        }

        public string ZipcodeSubString()
        {
            //LOCAL VARIABLES 
            string lastTwoDigits = "";

            lastTwoDigits = zipcode.Substring(zipcode.Length - 2);

            return lastTwoDigits;
        }

        public string FullMagCode()
        {
            return FullnameSplit() + BirthSubString() + (fullname.Length - 1) + MonthName() + ZipcodeSubString();
        }

        public override string ToString()
        {
            return $"{"Last Name:",5} {FullnameSplit(),2}" +
                   $"\n{"Year of Birth: ",5} {BirthSubString(),2}" +
                   $"\n{"Char Count of Fullname:",5} {(fullname.Length - 1),2}" +
                   $"\n{"Month of Subscription:",5} {MonthName(),2}" +
                   $"\n{"Last 2 Digits of Zipcode:",5} {ZipcodeSubString(),2}" +
                   $"\n{"Final Magazine Code:",5} {FullMagCode(),2}";
        }
    }
}
