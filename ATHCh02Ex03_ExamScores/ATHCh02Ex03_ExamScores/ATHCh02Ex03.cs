/*
 * Programmer: Tommie
 * Date: 01/31/2021
 * Project: Exam Scores
 * Chapter: 02 Ex: 03
 */

//DIRECTIVES
using System;
using static System.Console;

namespace ATHCh02Ex03_ExamScores
{
    class ATHCh02Ex03
    {
        static void Main()
        {
            //EXAM SCORES TO CALC
            int examOne = 100;
            int examTwo = 90;
            int examThree = 50;
            int examFour = 90;
            int examFive = 75;
            const int totalGrades = 5; 
  
            //CALC THE EXAM SCORES AVG
            double totalAvg = (double)(examOne + examTwo + examThree + examFour + examFive) / totalGrades;

            //PRINT EXAM SCORES AND TOTALS
            WriteLine("Exam One: " + examOne + 
                    "\nExam Two: " + examTwo +
                    "\nExam Three: " + examThree + 
                    "\nExam Four: " + examFour +
                    "\nExam Five: " + examFive);

            //PRINT TOTAL AVG OF ALL SCORES
            WriteLine($"Total Average: {totalAvg:f2}");

            //WAIT FOR USER KEY INPUT TO EXIT THE PROGRAM 
            ReadKey();
            
        }
    }
}

