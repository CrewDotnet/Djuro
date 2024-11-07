namespace CoffeeShop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coffee = new Coffee {BasePrice = 2};
            var order = new Order(new ConsoleActions());

            order.DisplayMenu();

            coffee.Name = order.SelectCoffee();

            coffee.Size = order.SelectSize();
            coffee.FullPrice = CalculateOrderPrice.Calculate(coffee);

            order.Display(coffee);


            
        }
    }
}
