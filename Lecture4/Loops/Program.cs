using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Loop
            //Loops 1+2+3+4+5+6
            //3+3=6+4=10+5=15+6=21

            //For(x; y; z;)
            //x: Start
            //y: End
            //z: Increment-Decrement

            int i;
            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("C# BootCamp");
            }

            for (int j = 0; j <= 20; j++)
            {
                Console.WriteLine(j);
            }

            for (int k = 0; k <= 50; k += 3)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("Please enter the number of times you want to display on the screen: ");
            int repetitionCount = int.Parse(Console.ReadLine());
            for (int l = 0; l < repetitionCount; l++)
            {
                Console.WriteLine("Long Live the Republic");
            }
            #endregion

            #region For Loop with Decision Structures
            for (int m = 1; m <= 100; m++)
            {
                if (m % 5 == 0)
                {
                    Console.WriteLine(m);
                }
            }

            int totalSum = 0;
            for (int n = 0; n <= 20; n++)
            {
                if (n % 2 == 0)
                {
                    totalSum += n;
                    Console.WriteLine(n);
                }
            }
            Console.WriteLine("--------");
            Console.WriteLine(totalSum);

            int multiplesOfSevenCount = 0;
            for (int p = 0; p <= 50; p++)
            {
                if (p % 7 == 0)
                {
                    multiplesOfSevenCount++;
                }
            }
            Console.WriteLine(multiplesOfSevenCount);

            // Example bacterium question: 1-2-4-8-16 ,,,
            int bacteria = 1;
            for (int q = 1; q <= 24; q++)
            {
                bacteria *= 2;
                Console.WriteLine(q + (".Hour After: " + bacteria));
            }
            #endregion

            #region While Loop
            //While(condition)
            //{
            //  operations
            //}

            int counter = 1;
            while (counter <= 10)
            {
                Console.WriteLine("Hello Loops");
                counter++;
            }

            int numberToCheck = 1;
            while (numberToCheck <= 10)
            {
                if (numberToCheck % 3 == 0)
                {
                    Console.WriteLine(numberToCheck);
                }
                numberToCheck++;
            }

            int numberSum = 1;
            int totalSumWhile = 0;
            while (numberSum <= 10)
            {
                totalSumWhile += numberSum;
                numberSum++;
            }
            Console.WriteLine(totalSumWhile);
            #endregion

            #region Example Exam Question
            // Write the code to calculate the sum of the digits of the 3-digit number entered from the keyboard.

            Console.WriteLine("Enter the number: ");
            int userInput = int.Parse(Console.ReadLine());

            int onesDigit, tensDigit, hundredsDigit;
            int digitSum;

            onesDigit = userInput % 10;
            hundredsDigit = userInput / 100;
            tensDigit = (userInput % 100) / 10;

            Console.WriteLine(hundredsDigit + "-" + tensDigit + "-" + onesDigit);
            digitSum = onesDigit + tensDigit + hundredsDigit;
            Console.WriteLine(digitSum);
            #endregion
        }
    }
}
