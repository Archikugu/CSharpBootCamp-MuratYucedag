using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methods

            // Methods that do not return a value
            // Customer --> List, Add, Delete, Update
            // Void

            void CustomerList()
            {
                Console.WriteLine("Gökhan GÖK");
                Console.WriteLine("Özge Şengezer");
            }

            CustomerList();

            void Sum()
            {
                int x = 1;
                int y = 2;
                int z = x + y;
                Console.WriteLine(z);
            }

            Sum();

            #endregion

            #region Parameterized Void Methods

            void WriteMethod(string customerName)
            {
                Console.WriteLine(customerName);
            }

            WriteMethod("Gökhan GÖK");

            void CustomerCard(string firstName, string lastName)
            {
                Console.WriteLine(firstName + " " + lastName);
            }

            CustomerCard("Gökhan", "Gök");
            CustomerCard("Özge", "Şengezer");

            void Subtract(int number1, int number2, int number3)
            {
                int result = number1 - number2 - number3;
                Console.WriteLine("Subtraction result: " + result);
            }
            Subtract(10, 3, 4);  

            #endregion

            #region Methods that Return a Value

            string CustomerName()
            {
                return "Özge Şengezer";
            }
            CustomerName();

            string StudentCard()
            {
                string name = "Gökhan";
                string surname = "GÖK";

                return name + " " + surname;
            }
            Console.WriteLine(StudentCard());

            #endregion

            #region Parameterized Methods that Return a Value

            string CountryCard(string countryName, string capitalName, string flagColor)
            {
                string cardInfo = "Country: " + countryName + " Capital: " + capitalName + " Flag Color: " + flagColor;
                return cardInfo;
            }

            string country, capital, flag;

            Console.WriteLine("Country Name: ");
            country = Console.ReadLine();

            Console.WriteLine("Capital Name: ");
            capital = Console.ReadLine();

            Console.WriteLine("Flag Color: ");
            flag = Console.ReadLine();

            Console.WriteLine(CountryCard(country, capital, flag));
            Console.WriteLine(CountryCard("Türkiye", "Ankara", "Red-White"));

            int Multiply(int number1, int number2)
            {
                int result = number1 * number2;
                return result;
            }
            Console.WriteLine("Multiplication result: " + Multiply(5, 4)); 

            #endregion

            #region Exam Application

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50 && result <= 100)
                {
                    return student + " passed the exam. Average: " + result;
                }
                else if (result >= 0 && result < 50)
                {
                    return student + " failed the exam. Average: " + result;
                }
                else
                {
                    return "Invalid value entered.";
                }
            }

            Console.WriteLine("Enter student name: ");
            string studentName = Console.ReadLine();

            Console.WriteLine("Enter first exam score: ");
            int score1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second exam score: ");
            int score2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third exam score: ");
            int score3 = int.Parse(Console.ReadLine());

            Console.WriteLine(ExamResult(studentName, score1, score2, score3));

            #endregion
        }
    }
}
