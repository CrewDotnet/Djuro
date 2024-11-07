using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop2
{
    public class Order : MenuBuilder
    {
        private static int CoffeeOption { get; set; }
        private static int SizeOption { get; set; }

        private readonly IConsole _console;

        public Order()
        {
        }
        public Order(IConsole console)
        {
            _console = console;
        }
        public void DisplayMenu()
        {
            FillMenu();

            _console.WriteLine("Please select your coffee : \n ");
            for (var i = 0; i < Menu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Menu[i].Name}");
            }

        }
        public string SelectCoffee()
        {
            CoffeeOption = int.Parse(_console.ReadLine());
            while (CoffeeOption > Menu.Count || CoffeeOption <= 0)
            {
                _console.WriteLine("Option doesn't exists, try again");
                CoffeeOption = int.Parse(_console.ReadLine());
            }
            for (var i = 0; i < Menu.Count; i++)
            {
                if (CoffeeOption - 1 == i)
                {
                    return Menu[i].Name;
                }
            }
            throw new Exception("Invalid character is entered");
        }
        public CoffeeSize SelectSize()
        {
            _console.WriteLine("Please select the coffee size : \n\n1. Regular \n2. Large \n");
            SizeOption = UserInput();

            while (SizeOption != 1 && SizeOption != 2)
            {
                _console.WriteLine("Invalid size option selected");
                _console.WriteLine("Please select the coffee size : \n\n1. Regular \n2. Large \n");
                UserInput();
            }
            if (SizeOption == 1)
                return CoffeeSize.Regular; 
            if (SizeOption == 2)
                return CoffeeSize.Large;
            throw new InvalidOperationException("Unexpected error: Invalid coffee size option.");
        }
        private int UserInput()
        {
            try
            {
                return int.Parse(_console.ReadLine());
            }
            catch (FormatException e)
            {
                _console.WriteLine("Invalid input. Please enter numeric value");
                return -1;
            }
        }
        public void Display(Coffee coffee)
        {
            _console.WriteLine($"You ordered {coffee.Size} {coffee.Name} with the price of {coffee.FullPrice}");
        }
    }
}
