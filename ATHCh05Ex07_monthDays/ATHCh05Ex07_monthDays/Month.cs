/*
 * Programmer: Tommie
 * Date: 03/30/2021
 * File: Month.cs
 * Instance Methods: Number Of Month 
 */

using System;


namespace ATHCh05Ex07_monthDays
{
    class Month
    {
        private int monthNum;


        //CONSTRUCTOR 

        public Month()
        {

        }

        public Month(int monthNum)
        {
            this.monthNum = monthNum;
        }

        //PROPERTIES 
        public int MonthNum
        {
            get
            {
                return monthNum;
            }
            set
            {
                monthNum = value;
            }
        }


        //METHODS 
        public string NumberOfDays()
        {
            string messageValue = "";

            if (monthNum == 1)
            {
                messageValue = $"Input: {monthNum}\nMonth:January\nNumber Of Days: 31";
            }
            if (monthNum == 2)
            {
                messageValue = $"Input: {monthNum}\nMonth:February\nNumber Of Days: 28";
            }
            if (monthNum == 3)
            {
                messageValue = $"Input: {monthNum}\nMonth:March\nNumber Of Days: 31";
            }
            if (monthNum == 4)
            {
                messageValue = $"Input: {monthNum}\nMonth:April\nNumber Of Days: 30";
            }
            if (monthNum == 5)
            {
                messageValue = $"Input: {monthNum}\nMonth:May\nNumber Of Days: 31";
            }
            if (monthNum == 6)
            {
                messageValue = $"Input: {monthNum}\nMonth:June\nNumber Of Days: 30";
            }
            if (monthNum == 7)
            {
                messageValue = $"Input: {monthNum}\nMonth:July\nNumber Of Days: 31";
            }
            if (monthNum == 8)
            {
                messageValue = $"Input: {monthNum}\nMonth:August\nNumber Of Days: 31";
            }
            if (monthNum == 9)
            {
                messageValue = $"Input: {monthNum}\nMonth:September\nNumber Of Days: 30";
            }
            if (monthNum == 10)
            {
                messageValue = $"Input: {monthNum}\nMonth:October\nNumber Of Days: 31";
            }
            if (monthNum == 11)
            {
                messageValue = $"Input: {monthNum}\nMonth:November\nNumber Of Days: 30";
            }
            if (monthNum == 12)
            {
                messageValue = $"Input: {monthNum}\nMonth:December\nNumber Of Days: 31";
            }

            return messageValue;
        }

        public override string ToString()
        {
            return "+----------------------------------+" +
                   $"\n{NumberOfDays().ToString()}" +
                   "\n+----------------------------------+";
        }
    }
}
