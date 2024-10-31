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
            CoffeeOption = int.Parse(Console.ReadLine());
            while (CoffeeOption > Menu.Count || CoffeeOption <= 0)
            {
                Console.WriteLine("Option doesn't exists, try again");
                CoffeeOption = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < Menu.Count; i++)
            {
                if (CoffeeOption - 1 == i)
                {
                    return Menu[i].Name;
                }
            }
            throw new Exception("Invalid character is entered");
        }
        public static CoffeeSize SelectSize()
        {
            Console.WriteLine("Please select the coffee size : \n\n1. Regular \n2. Large \n");
            SizeOption = int.Parse(Console.ReadLine());

            if (SizeOption == 1)
                return CoffeeSize.Regular;
            else if (SizeOption == 2)
                return CoffeeSize.Large;
            else
                Console.WriteLine("Invalid size option selected");
            Environment.Exit(0);

            throw new InvalidOperationException();
        }

        public static void DisplayOrder(Coffee coffee)
        {
            Console.WriteLine($"You ordered {coffee.Size} {coffee.Name} with the price of {coffee.FullPrice}");
        }
    }
}
