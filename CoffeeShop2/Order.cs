using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop2
{
    public class Order : MenuBuilder
    {
        private static int CoffeeOption { get; set; }
        private static int SizeOption { get; set; }

        public static void DisplayMenu()
        {
            FillMenu();

            Console.WriteLine("Please select your coffee : \n ");
            for (int i = 0; i < Menu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Menu[i].Name}");
            }

        }

        public static string SelectCoffee()
        {
            try
            {
                CoffeeOption = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input");
                return null;
            }
            for (int i = 0; i < Menu.Count; i++)
            {
                if (CoffeeOption - 1 == i)
                {
                    return Menu[i].Name;
                }
            }
            throw new Exception("Not an option");
        }
        public static string SelectSize()
        {
            Console.WriteLine("Please select the coffee size : \n\n1. Regular \n2. Large \n");
            SizeOption = int.Parse(Console.ReadLine());
            switch (SizeOption)
            {
                case 1:
                    return "Regular";
                case 2:
                    return "Large";

            }
            return "Invalid option";
        }

        public static void DisplayOrder(string coffeeName, string coffeeSize, decimal price)
        {
            Console.WriteLine("You ordered " + coffeeSize + " " + coffeeName + " and price is : " + price);
        }
    }
}
