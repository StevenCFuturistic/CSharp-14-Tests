using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/* 
 14. Write a program named Tests that declares five variables to hold scores for five tests you have taken, and assign a value to each variable. Display the average of the test scores to two decimal places. 15. Modify the Tests program to create

Farrell, Joyce. Microsoft Visual C# 2015: An Introduction to Object-Oriented Programming (Page 97). Course Technology. Kindle Edition. 
Author: Steven C Love, 3/25/2019
 */

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {

            // variables
            double testScore1,
                testScore2 ,
                testScore3 ,
                testScore4 ,
                testScore5;
            double testScoreAverage;
            double total;
            string testscore1AsString,
                testScore2AsString, testScore3AsString, testScore4AsString,
                testScore5AsString;


            Write(" Enter your 1st test score >> \n");
            testscore1AsString = ReadLine();
            testScore1 = Convert.ToDouble(testscore1AsString);
            Write(" Enter your 2nd test score >> \n");
            testScore2AsString = ReadLine();
            testScore2 = Convert.ToDouble(testScore2AsString);
            Write(" Enter your 3rd test score >> \n");
            testScore3AsString = ReadLine();
            testScore3 = Convert.ToDouble(testScore3AsString);
            Write(" Enter your 4th test score >> \n");
            testScore4AsString = ReadLine();
            testScore4 = Convert.ToDouble(testScore4AsString);
            Write(" Enter your 5th test score >> \n");
            testScore5AsString = ReadLine();
            testScore5 = Convert.ToDouble(testScore5AsString);

            // Calculations


            total = testScore1 + testScore2 + testScore3 + testScore4 + testScore5;
            testScoreAverage = total / 5;
                
                // Outputs

            Write(" Your average for these 5 test scores is: {0} \n ", testScoreAverage.ToString("P"));







            Console.ReadKey();

        }
    }
}
