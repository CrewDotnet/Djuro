using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop2
{
    public class Coffee
    {
        public string Name { get; set; }
        public CoffeeSize Size { get; set; }
        public decimal BasePrice { get; set; }
        public decimal FullPrice { get; set; }

    }
}
