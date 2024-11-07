using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop2
{
    public class CalculateOrderPrice
    {
        public static decimal Calculate(Coffee coffee)
        {
            var calculatedPrice = coffee.BasePrice * 1.2m;
            return coffee.Size == CoffeeSize.Large ? calculatedPrice : coffee.BasePrice;
        }

    }
}
