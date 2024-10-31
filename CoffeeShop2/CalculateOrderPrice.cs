using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop2
{
    public class CalculateOrderPrice
    {
        public static decimal Calculate(decimal basePrice, CoffeeSize size)
        {
            var calculatedPrice = basePrice * 1.2m;
            return size == CoffeeSize.Large ? calculatedPrice : basePrice;
        }

    }
}
