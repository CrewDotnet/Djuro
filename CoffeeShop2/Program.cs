namespace CoffeeShop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coffee = new Coffee {BasePrice = 2};

            Order.DisplayMenu();

            coffee.Name = Order.SelectCoffee();

            coffee.Size = Order.SelectSize();
            coffee.FullPrice = CalculateOrderPrice.Calculate(coffee.BasePrice, coffee.Size);

            Order.DisplayOrder(coffee);


            
        }
    }
}
