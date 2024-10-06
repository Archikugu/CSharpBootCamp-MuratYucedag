using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else Section

            #region Password Check
            Console.WriteLine("Please enter the password: ");
            string password;
            password = Console.ReadLine();
            if (password == "abcd")
            {
                Console.WriteLine("Password Correct");
            }
            else
            {
                Console.WriteLine("Password Incorrect");
            }
            #endregion

            #region Capital and Country Check
            string capital, country;
            Console.WriteLine("Enter the capital: ");
            capital = Console.ReadLine();
            Console.WriteLine("Enter the country: ");
            country = Console.ReadLine();

            if (capital == "ankara" && country == "turkey")
            {
                Console.WriteLine("Correct Information");
            }
            else
            {
                Console.WriteLine("Incorrect Information");
            }
            #endregion

            #region Number Check
            int number;
            Console.WriteLine("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("Number Correct");
            }
            else
            {
                Console.WriteLine("Number Incorrect");
            }
            #endregion

            #region Exam Grade Check
            //int exam1, exam2, exam3, average;
            //string result;

            //Console.WriteLine("Exam 1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Exam 2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Exam 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //if (average > 0 && average <= 50)
            //{
            //    result = "Result: Poor";
            //}
            //else if (average > 50 && average <= 70)
            //{
            //    result = "Result: Average";
            //}
            //else if (average > 70 && average <= 85)
            //{
            //    result = "Result: Good";
            //}
            //else if (average > 85 && average <= 100)
            //{
            //    result = "Result: Excellent";
            //}
            //else
            //{
            //    result = "Invalid Score Entry";
            //}

            //Console.WriteLine(result);
            #endregion

            #region City Check
            string city;
            Console.WriteLine("Enter the city: ");
            city = Console.ReadLine();

            if (city == "ankara" || city == "adana" || city == "bursa" || city == "istanbul")
            {
                Console.WriteLine("City Exists");
            }
            else
            {
                Console.WriteLine("City Does Not Exist");
            }
            #endregion

            #region Username Check
            Console.WriteLine("Please enter the username: ");
            string username = Console.ReadLine();
            if (username != "admin")
            {
                Console.WriteLine("Username Not Accepted");
            }
            else
            {
                Console.WriteLine("Welcome");
            }
            #endregion

            #endregion

            #region Modulus Operations

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.WriteLine("Please enter the first number: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter the second number: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("The remainder of the division of the first number by the second number is: " + result);

            //Console.WriteLine("Please enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("The number is even");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd");
            //}

            #endregion

            #region Decision Making with Char Variables

            char team;
            Console.WriteLine("Please enter the team symbol: ");
            team = char.Parse(Console.ReadLine());
            if (team == 'g' || team == 'G')
            {
                Console.WriteLine("Galatasaray");
            }
            if (team == 'f' || team == 'F')
            {
                Console.WriteLine("Fenerbahçe");
            }
            if (team == 'b' || team == 'B')
            {
                Console.WriteLine("Beşiktaş");
            }

            #endregion

            #region Sample Project Application

            Console.WriteLine("***** C# Training Camp Restaurant");
            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine("1-Main Courses");
            Console.WriteLine("2-Soups");
            Console.WriteLine("3-Pizzas");
            Console.WriteLine("4-Drinks");
            Console.WriteLine("5-Desserts");
            Console.WriteLine("---------------");
            Console.WriteLine();

            string menuItem;
            Console.Write("Select the menu you want to see details for:");
            menuItem = Console.ReadLine();
            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("-------Main Courses--------");
                Console.WriteLine();
                Console.WriteLine("1-Chicken with Curry Sauce");
                Console.WriteLine("2-Fried Plate");
                Console.WriteLine("3-Beans with Rice");
                Console.WriteLine("4-Baked Salmon");
                Console.WriteLine("5-Eggplant Moussaka");
                Console.WriteLine();
            }
            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("-------Soups--------");
                Console.WriteLine();
                Console.WriteLine("1-Lentil Soup");
                Console.WriteLine("2-EzoGelin Soup");
                Console.WriteLine("3-Chicken Broth Soup");
                Console.WriteLine();
            }
            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("-------Pizzas--------");
                Console.WriteLine();
                Console.WriteLine("1-Margherita Pizza");
                Console.WriteLine("2-Mediterranean Pizza");
                Console.WriteLine("3-Sausage Lover Pizza");
                Console.WriteLine("4-Chicken Pizza");
                Console.WriteLine();
            }
            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("-------Drinks--------");
                Console.WriteLine();
                Console.WriteLine("1-Coke");
                Console.WriteLine("2-Fanta");
                Console.WriteLine("3-Ayran");
                Console.WriteLine("4-Turnip Juice");
                Console.WriteLine("5-Water");
                Console.WriteLine();
            }
            if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("-------Desserts--------");
                Console.WriteLine();
                Console.WriteLine("1-Trilece");
                Console.WriteLine("2-Kazandibi");
                Console.WriteLine("3-Rice Pudding");
                Console.WriteLine("4-Muhallebi");
                Console.WriteLine("5-Cheesecake");
                Console.WriteLine();
            }
            #endregion

            #region Switch Case

            Console.WriteLine("Please enter the month number: ");
            int monthNumber = int.Parse(Console.ReadLine());
            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            #endregion

            #region Switch Case Calculator

            int number1, number2, result;
            char symbol;

            Console.WriteLine("Please enter the first number: ");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the operation you want to perform: ");

            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Sum: " + result);
                    break;

                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Difference: " + result);
                    break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Product: " + result);
                    break;

                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Quotient: " + result);
                    break;

                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            #endregion

        }
    }
}
