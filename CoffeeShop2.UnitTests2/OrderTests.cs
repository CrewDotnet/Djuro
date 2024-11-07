using System;
using System.IO;
using NUnit.Framework;
using CoffeeShop2;
using Moq;

namespace CoffeeShop2.UnitTests2
{
    [TestFixture]
    public class OrderTests
    {
        [Test]
        public void SelectSize_WhenCalled_ReturnCoffeeSizeLarge()
        {

            var inputReader = new Mock<IConsole>();
            inputReader.Setup(ir => ir.ReadLine()).Returns("2");
            var order = new Order(inputReader.Object);

            var result = order.SelectSize();

            Assert.That(CoffeeSize.Large.Equals(result));

        }
        [Test]
        public void SelectSize_WhenCalled_ReturnCoffeeSizeRegular()
        {

            var inputReader = new Mock<IConsole>();
            inputReader.Setup(ir => ir.ReadLine()).Returns("1");
            var order = new Order(inputReader.Object);

            var result = order.SelectSize();

            Assert.That(CoffeeSize.Regular == result);
        }

    }
}
