using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop2
{
    public class CalculateOrderPrice
    {
        public decimal Calculate(decimal price, string size)
        {
            if (size == null)
            {
                throw new ArgumentNullException("size");
            }
            if (size.ToLower() == "large")
            {
                return price * (decimal)1.2;
            }
            return price;
        }

    }
}
