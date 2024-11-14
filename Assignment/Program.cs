// See https://aka.ms/new-console-template for more information

using Assignment;

Console.WriteLine("\r\nBienvenue dans mon café");

//Simplified menu builder
Console.WriteLine("\r\n Please choose your coffee and the size.");
Console.WriteLine("\r\n You can select:");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("\r\n Espresso");
Console.WriteLine("\r\n Latte Macchiato");
Console.WriteLine("\r\n Cappuccino");
Console.WriteLine("--------------------------------------------");

Console.WriteLine("\r\n Cup size: Large or regular");
Console.WriteLine("--------------------------------------------");

//HARDCODED values, avoid any input validations (test with all possible variations)
string coffeeName = "Cappuccino";
string size = "Large";
//

// TODO: put some code below
// print the calculated price of the ordered coffee and the full name of the ordered coffee (name + size)
var coffee = new Coffee();

coffee.Name = coffeeName;
coffee.Size = size;

var fullPrice = Calculate.CalculatePrice(coffee);


//printing the message - results of the code
Console.WriteLine($"\r\nYour order: {coffee.Name} {coffee.Size} | price: {fullPrice}");  //full name
Console.WriteLine("\r\nThank you, come again!");
