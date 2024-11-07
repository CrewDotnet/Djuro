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
        public void Calculate_WhenCalled_ReturnsLargeCoffeePrice()
        {
            var coffee = new Coffee
            {
                BasePrice = 2,
                Size = CoffeeSize.Large
            };

            var expectedPrice = CalculateOrderPrice.Calculate(coffee);

            Assert.That(expectedPrice, Is.EqualTo(coffee.BasePrice * 1.2m));
        }
        [Test]
        public void Calculate_WhenCalled_ReturnsRegularCoffeePrice()
        {
            var coffee = new Coffee
            {
                BasePrice = 2,
                Size = CoffeeSize.Regular
            };

            var expectedPrice = CalculateOrderPrice.Calculate(coffee);

            Assert.That(expectedPrice, Is.EqualTo(coffee.BasePrice));
        }

    }
}
