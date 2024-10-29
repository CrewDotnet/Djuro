using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop2
{
    public class MenuBuilder
    {
        public static List<Coffee> Menu { get; set; } = new List<Coffee>();

        public static List<Coffee> FillMenu()
        {
            var coffee1 = new Coffee { Name = "Machiato" };
            var coffee2 = new Coffee { Name = "Espresso" };
            var coffee3 = new Coffee { Name = "Capuccino" };

            Menu.Add(coffee1);
            Menu.Add(coffee2);
            Menu.Add(coffee3);

            return Menu;
        }






    }
}
