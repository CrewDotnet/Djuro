using System;
using System.IO;
using NUnit.Framework;

namespace CoffeeShop2.UnitTests
{
    [TestFixture]
    public class OrderTests
    {
        [Test]
        public void SelectSize_WhenCalled_ReturnCoffeeSize()
        {
            var input = new StreamReader("1");
            Console.SetIn(input);
            var order = new Order();

            var result = Order.SelectSize(input);
        }
    }
}
