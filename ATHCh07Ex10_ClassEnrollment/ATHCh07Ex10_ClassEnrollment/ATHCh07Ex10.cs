/*
 * Programmer: Tommie
 * File: ATHCh07Ex10.cs
 * Date: 04/26/2021
 * Project: Class Enrollment
 * Ch:07 Ex:10
*/

//DIRECTIVES
using System;
using static System.Console;

namespace ATHCh07Ex10_ClassEnrollment
{
    class ATHCh07Ex10
    {
        static void Main()
        {
            string[] className = { "CS150", "CS250", "CS270", "CS300", "CS350" };
            int[] currentEnrollment = { 180, 21, 9, 4, 20 };
            int[] maxEnrollment = { 200, 30, 20, 20, 20 };
            Courses[] class_one = new Courses[5];

            for (int i = 0; i < className.Length; i++)
            {
                class_one[i] = new Courses(className[i], currentEnrollment[i], maxEnrollment[i]);
                class_one[i].EnrollmentCalc();
                WriteLine(class_one[i].ToString());
            }

            //WAIT FOR USER INPUT TO EXIT SCREEN
            WriteLine("Press any key to exit program...");
            ReadKey();

        }
    }
}
