namespace CoffeeShop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var price = 2;

            Order.DisplayMenu();
            var selectedCoffee = Order.SelectCoffee();

            var size = Order.SelectSize();

            var orderPriceCalculation = new CalculateOrderPrice();
            var orderPrice = orderPriceCalculation.Calculate(price, size);

            Order.DisplayOrder(selectedCoffee, size, orderPrice);


            
        }
    }
}
