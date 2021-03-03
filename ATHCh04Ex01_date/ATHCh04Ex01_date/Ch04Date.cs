using System;

/*
 * Programmer: Tommie
 * Date: 03/02/2021
 * Inst Class: Ch04Date
 * Data Members: Year | Day | Month As Number | Month As Name
 */

namespace ATHCh04Ex01_date
{
    class Ch04Date
    {
        //INST VARIABLES
        private int year,
                    day,
                    monthInNumberFormat;

        private string monthInNameFormat;


        //CONSTRUCTORS
        public Ch04Date()
        {

        }

        //MONTH NAME IN DATE CONSTRUCTOR
        public Ch04Date(string monthName, int dayDate, int yearDate)
        {
            monthInNameFormat = monthName;
            day = dayDate;
            year = yearDate;
        }

        //MONTH NUMBER IN DATE CONSTRUCTO 
        public Ch04Date(int monthNum, int dayDate, int yearDate)
        {
            monthInNumberFormat = monthNum;
            day = dayDate;
            year = yearDate;
        }


        //PROPERTIES
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public int MonthInNumberFormat
        {
            get
            {
                return monthInNumberFormat;
            }
            set
            {
                monthInNumberFormat = value;
            }
        }

        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }

        public string MonthInNameFormat
        {
            get
            {
                return monthInNameFormat;
            }
            set
            {
                monthInNameFormat = value;
            }
        }


        //METHODS 
        public string MonthName()
        {
            return $"Date: {monthInNameFormat} {day},{year}";
        }


        // OVERRIDE TO RETURN VALUES
        public override string ToString()
        {
            return $"Date: {monthInNumberFormat}/{day}/{year}";
        }
    }
}
