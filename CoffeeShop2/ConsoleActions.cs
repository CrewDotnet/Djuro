using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop2
{
    public class ConsoleActions : IConsole
    {
        public string ReadLine()
        {
            return Console.ReadLine() ?? throw new InvalidOperationException();
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }

}
