using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basic Array Examples
            // VariableType[] ArrayName = new VariableType[NumberOfElements];
            string[] colors = new string[4];
            colors[0] = "Blue";
            colors[1] = "Red";
            colors[2] = "Green";
            colors[3] = "Purple";
            Console.WriteLine(colors[1]);

            string[] cities =
            {
                "Milan",
                "Budapest",
                "Lyon",
                "Cairo",
                "Skopje",
                "Istanbul"
            };

            int[] numbers = new int[]
            {
                10,
                20,
                30,
                40,
                50
            };
            #endregion

            #region Listing All Elements in an Array
            string[] mainColors = { "yellow", "red", "navy", "white", "blue", "green", "orange", "pink" };
            for (int i = 0; i < mainColors.Length; i++)
            {
                Console.WriteLine(mainColors[i]);
            }

            int[] numbers1 = { 4, 85, 789, 45, 741, 8520, 65, 94, 71 };
            foreach (int number in numbers1)
            {
                if (number % 3 == 0)
                {
                    Console.WriteLine(number);
                }
            }

            char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            for (int i = 0; i < symbols.Length; i++)
            {
                Console.WriteLine(symbols[i]);
            }

            int[] myArray = { 0, 125, 45, 78, 95, 45, 65, 12, 32, 74, 589, 741, 456 };
            int maxNumber = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > maxNumber)
                {
                    maxNumber = myArray[i];
                }
            }
            Console.WriteLine(maxNumber);

            string[] persons = { "Gokhan", "Ozge", "Murat", "Engin", "Deniz", "Gunes" };
            Console.WriteLine(persons.Length);

            int[] numbers2 = { 10, 4, 5, 0, 789, 65, 54, 42, 126, 16, 98, 75 };
            Array.Sort(numbers2);
            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine(numbers2[i]);
            }

            int[] numbers3 = { 10, 4, 5, 0, 789, 65, 54, 42, 126, 16, 98, 75 };
            Array.Reverse(numbers3);
            for (int i = 0; i < numbers3.Length; i++)
            {
                Console.WriteLine(numbers3[i]);
            }
            #endregion

            #region Array Methods
            string[] customers = { "Gokhan", "Ozge", "Murat", "Engin", "Deniz", "Gunes" };
            int index = Array.IndexOf(customers, "Ozge");
            Console.WriteLine(index);

            int[] numbers4 = { 10, 4, 5, 0, 789, 65, 54, 42, 126, 16, 98, 75 };
            Console.WriteLine("Largest Element in the Array: " + numbers4.Max() + " Smallest Element in the Array: " + numbers4.Min());
            #endregion

            #region Getting Values from User
            // Get an array of countries from the user
            string[] countries = new string[5];
            for (int i = 0; i < countries.Length; i++)
            {
                Console.WriteLine($"Please enter the name of country {i + 1}: ");
                countries[i] = Console.ReadLine();
            }

            Console.WriteLine("-----------");

            for (int i = 0; i < countries.Length; i++)
            {
                Console.WriteLine(countries[i]);
            }

            // Sum of elements in an array
            int[] numbers5 = { 10, 20, 30, 40, 50 };
            int sum = 0;
            for (int i = 0; i < numbers5.Length; i++)
            {
                sum += numbers5[i];
            }
            Console.WriteLine("Sum of numbers: " + sum);
            #endregion

            #region Get Values from User and Separate Even and Odd Numbers
            // Get an array of integers from the user
            int[] userNumbers = new int[10];
            for (int i = 0; i < userNumbers.Length; i++)
            {
                Console.WriteLine($"Please enter number {i + 1}: ");
                userNumbers[i] = int.Parse(Console.ReadLine());
            }

            // Display even numbers
            Console.WriteLine("Even Numbers:");
            for (int i = 0; i < userNumbers.Length; i++)
            {
                if (userNumbers[i] % 2 == 0)
                {
                    Console.WriteLine(userNumbers[i]);
                }
            }

            // Display odd numbers
            Console.WriteLine("Odd Numbers:");
            for (int i = 0; i < userNumbers.Length; i++)
            {
                if (userNumbers[i] % 2 == 1)
                {
                    Console.WriteLine(userNumbers[i]);
                }
            }
            #endregion
        }
    }
}
