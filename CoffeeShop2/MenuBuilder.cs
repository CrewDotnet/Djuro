using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop2
{
    public class MenuBuilder : Coffee
    {
        public static List<Coffee> Menu { get; set; } = [];
        private static readonly List<Coffee> Coffees =
        [
            new (){Name = "Espresso"},
            new (){Name = "Macchiato"},
            new (){Name = "Cappuccino"},
        ];

        public static List<Coffee> FillMenu()
        {
            foreach (var coffee in Coffees)
            {
                Menu.Add(coffee);
            }
            return Menu;
        }






    }
}
