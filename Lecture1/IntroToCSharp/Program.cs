using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Print Commands
            Console.WriteLine("***** Food Categories *****");
            Console.WriteLine();
            Console.WriteLine("1-Soups");
            Console.WriteLine("2-Main Dishes");
            Console.WriteLine("3-Cold Starters");
            Console.WriteLine("4-Salads");
            Console.WriteLine("5-Desserts");
            Console.WriteLine("6-Drinks");
            Console.WriteLine();
            Console.WriteLine("***** Food Categories *****");
            #endregion

            #region String Variables

            // string
            //data_type variable_name;

            string name;
            name = "Gokhan";
            Console.WriteLine(name);

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Ozge";
            customerSurname = "Sengezer";
            customerPhone = "+90 123 456 78 90";
            customerEmail = "ozgesengezer@gmail.com";
            district = "Çankaya";
            city = "Ankara";

            Console.WriteLine("**** Reservation Card ****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Customer: " + customerName + " " + customerSurname);
            Console.WriteLine("Contact: " + customerPhone);
            Console.WriteLine("Email Address: " + customerEmail);
            Console.WriteLine("Address: " + district + "/" + city);
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine();

            customerName = "Gokhan";
            customerSurname = "Gok";
            customerPhone = "+90 500 123 45 67";
            customerEmail = "engokhangok@gmail.com";
            district = "Yenimahalle";
            city = "Ankara";

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Customer: " + customerName + " " + customerSurname);
            Console.WriteLine("Contact: " + customerPhone);
            Console.WriteLine("Email Address: " + customerEmail);
            Console.WriteLine("Address: " + district + "/" + city);
            Console.WriteLine("-------------------------------------------------");

            #endregion

            #region Int Variables

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restaurant Menu Prices ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("-----Coke: " + cokePrice + " TL");
            Console.WriteLine("-----Lemonade: " + lemonadePrice + " TL");
            Console.WriteLine("-----Fries: " + friesPrice + " TL");
            Console.WriteLine("-----Water: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restaurant Menu Prices ****");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 4;
            cokeCount = 3;
            waterCount = 2;
            friesCount = 1;
            pizzaCount = 5;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Hamburger Total: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Total: " + totalPizzaPrice + " TL");
            Console.WriteLine("Fries Total: " + totalFriesPrice + " TL");
            Console.WriteLine("Coke Total: " + totalCokePrice + " TL");
            Console.WriteLine("Lemonade Total: " + totalLemonadePrice + " TL");
            Console.WriteLine("Water Total: " + totalWaterPrice + " TL");

            Console.WriteLine();

            int totalPrice = totalCokePrice + totalWaterPrice + totalLemonadePrice + totalHamburgerPrice + totalPizzaPrice + totalFriesPrice;

            Console.WriteLine("Total Amount Due: " + totalPrice + " TL");

            #endregion
        }
    }
}
