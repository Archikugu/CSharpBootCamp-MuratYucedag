using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Loop

            //Foreach (//1; //2; //3; //4)

            //1 Variable Type
            //2 Variable Name
            //3 In
            //4 List, Collection, Array

            string[] cities = { "Milan", "Rome", "Budapest", "Istanbul", "Warsaw" };

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            int[] numbers = { 45, 87, 654, 985, 745, 632, 12, 43 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Even Numbers: ");

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }

            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            Console.WriteLine("Total of the Numbers: {0}", total);

            List<int> numbers1 = new List<int>()
            {
                1, 2, 3, 4, 5
            };
            foreach (var number in numbers1)
            {
                Console.WriteLine(number);
            }

            string word = "Hello";
            foreach (char c in word)
            {
                Console.WriteLine(c);
            }

            #endregion

            #region Sample Exam System

            Console.WriteLine("**** C# Bootcamp Exam Application ****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Getting the number of students in the class from the user
            Console.WriteLine("-------------");
            Console.WriteLine("How many students are in your class: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------");

            string[] studentNames = new string[studentCount];
            double[] examAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"Enter the name of student {i + 1}:");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // Entering 3 exam scores for each student
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter the score for exam {j + 1} of student {studentNames[i]}: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; // Adding the scores
                }

                examAvg[i] = totalExamResult / 3;
            }
            Console.WriteLine("-------------");
            for (int i = 0; i < studentCount; i++)
            {
                if (examAvg[i] >= 50 && examAvg[i] <= 100)
                {
                    Console.WriteLine($"{studentNames[i]}'s average score: {examAvg[i]} Passed the course");
                }
                else if (examAvg[i] < 50 && examAvg[i] >= 0)
                {
                    Console.WriteLine($"{studentNames[i]}'s average score: {examAvg[i]} Failed the course");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]}'s average score: {examAvg[i]} Invalid score entered");
                }

            }
            Console.WriteLine("-------------");

            #endregion
        }
    }
}
