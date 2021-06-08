/*
 * Programmer: Tommie
 * File: Courses.cs
 * Instance Variables: name of Courses | Current Enrollment | Max Enrollment
 * Date: 04/26/2021
 */

using System;


namespace ATHCh07Ex10_ClassEnrollment
{
    class Courses
    {
        private string nameOfCourse;
        private int
                currentEnrollment,
                maxEnrollment;

        //CONSTURCTORS 
        public Courses()
        {

        }

        public Courses(string name, int currentEnroll, int maxEnroll)
        {
            nameOfCourse = name;
            currentEnrollment = currentEnroll;
            maxEnrollment = maxEnroll;
        }

        //PROPERTIES 
        public string NameOfCourses
        {
            get
            {
                return nameOfCourse;
            }
            set
            {
                nameOfCourse = value;
            }
        }

        public int CurrentEnrollment
        {
            get
            {
                return CurrentEnrollment;
            }
            set
            {
                CurrentEnrollment = value;
            }
        }

        public int MaxEnrollment
        {
            get
            {
                return maxEnrollment;
            }
            set
            {
                maxEnrollment = value;
            }
        }

        //INSTANCE METHOD 
        public int EnrollmentCalc()
        {
            int canEnroll;

            if (currentEnrollment < maxEnrollment)
            {
                canEnroll = maxEnrollment - currentEnrollment;
            }
            else
            {
                canEnroll = 0;
            }

            return canEnroll;
        }

        public override string ToString()
        {
            return "+----------------------------------------------------------------------------------+" +
                    $"\n{"Class Name",15} {"Current Enrollment",20} {"Maximum Enrollment",25} {"Available",15}" +
                    $"\n{nameOfCourse,11} {currentEnrollment,15} {maxEnrollment,26} {EnrollmentCalc().ToString(),19}" +
                    "\n+----------------------------------------------------------------------------------+" + 
                    "\n";
        }



    }
}
