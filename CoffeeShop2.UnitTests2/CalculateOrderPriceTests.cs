using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop2.UnitTests2
{
    [TestFixture]
    public class CalculateOrderPriceTests
    {
        [Test]
        public void Calculate_WhenCalled_ReturnsCalculatedPrice()
        {
            var coffee = new Coffee();
            var expectedPrice = CalculateOrderPrice.Calculate(coffee);

            Assert.That(calculatedPrice.Equals(expectedPrice));
        }

    }
}
