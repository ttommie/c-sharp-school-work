/*
 * Programmer: Tommie
 * Date: 01/23/2021
 * Project: Information Box Using Write() Method
 * Chapter: 01 Ex: 07
 */

//DIRECTIVES
using System;
using static System.Console;

namespace ATHCh01Ex07_InfoBox
{
    class ATHCh01Ex07
    {
        static void Main()
        {
            //PRINT INFO BOX WITH INFORMATION ABOUT MYSELF TO THE CONSOLE
            Write("**************************************************\n" +
                  "*|\tName: Tommie\\\t\t\t\t *\n" +
                  "* \tHometown: Unknown\\\t\t\t *\n" +
                  "* \tMajor: Computer Programming\\\t\t *\n" +
                  "* \tHobby: Playing Piano\\\t\t\t *\n" +
                  "* \tFavorite Activity: Listening to Music\\\t|*\n" +
                  "**************************************************");
            //WAITING FOR USER KEY INPUT TO EXIT THE PROGRAM
            ReadKey();
        }
    }
}
