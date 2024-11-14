using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public static class Calculate
    {
        public static decimal CalculatePrice(Coffee coffee)
        {
            var calculatedPrice = coffee.Price * 1.2m;
            return coffee.Size == "Large" ? calculatedPrice : coffee.Price;
        }
    }
}
