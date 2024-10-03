using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Variables

            double number;

            number = 4.85;

            Console.WriteLine(number);

            Console.WriteLine("***** Price List *****");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine("---- Apple Unit Price: " + applePrice + " TL");
            Console.WriteLine("---- Orange Unit Price: " + orangePrice + " TL");
            Console.WriteLine("---- Strawberry Unit Price: " + strawberryPrice + " TL");
            Console.WriteLine("---- Potato Unit Price: " + potatoPrice + " TL");
            Console.WriteLine("---- Tomato Unit Price: " + tomatoPrice + " TL");

            Console.WriteLine();
            Console.WriteLine();

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;

            Console.WriteLine("Purchased Product: Apple - " + "Unit Price: " + applePrice + " - Weight: " + appleGram + " - Total Amount: " + appleTotalPrice);

            Console.WriteLine("Purchased Product: Orange - " + "Unit Price: " + orangePrice + " - Weight: " + orangeGram + " - Total Amount: " + orangeTotalPrice);

            Console.WriteLine("Purchased Product: Strawberry - " + "Unit Price: " + strawberryPrice + " - Weight: " + strawberryGram + " - Total Amount: " + strawberryTotalPrice);

            Console.WriteLine("Purchased Product: Potato - " + "Unit Price: " + potatoPrice + " - Weight: " + potatoGram + " - Total Amount: " + potatoTotalPrice);

            Console.WriteLine("Purchased Product: Tomato - " + "Unit Price: " + tomatoPrice + " - Weight: " + tomatoGram + " - Total Amount: " + tomatoTotalPrice);

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Total Shopping Amount: " + shoppingTotalPrice + " TL");

            #endregion

            #region Char Variables

            char symbol;
            symbol = 'a';

            Console.WriteLine(symbol);

            #endregion

            #region Keyboard Input for String Variables

            Console.WriteLine("**** CSharp Airlines Passenger Information ****");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            Console.Write("Passenger Name: ");
            passengerName = Console.ReadLine();

            Console.Write("Passenger Surname: ");
            passengerSurname = Console.ReadLine();

            Console.Write("District Information: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("City Information: ");
            passengerCity = Console.ReadLine();

            Console.Write("Passenger Age: ");
            passengerAge = Console.ReadLine();

            Console.Write("Passenger ID Number: ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("-----------------------");
            Console.WriteLine("Passenger ID Number: " + passengerIdentityNumber + " - Passenger Full Name: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);

            #endregion

            #region Keyboard Input for Integer Entries and Conversions

            //ABC12D

            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.Write("Please enter the number of shoes purchased: ");
            shoesCount = int.Parse(Console.ReadLine());

            Console.Write("Please enter the number of computers purchased: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Please enter the number of chairs purchased: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Please enter the number of televisions purchased: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            Console.WriteLine();
            Console.WriteLine("Total Amount to be Paid: " + totalPrice);

            #endregion

            #region Keyboard Input for Decimal Operations

            double exam1, exam2, exam3, result;

            Console.Write("Please enter the 1st exam score: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Please enter the 2nd exam score: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Please enter the 3rd exam score: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine();
            Console.WriteLine("Your Exam Average: " + result);

            #endregion

            #region Keyboard Input for Character Entries

            char gender;
            Console.Write("Please select gender: ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Selected Gender: " + gender);
            #endregion

        }
    }
}
