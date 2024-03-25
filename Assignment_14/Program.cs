// See https://aka.ms/new-console-template for more information
using Assignment_14;

Console.WriteLine("Hello, World!");


ICoffee espresso = CoffeeFactory.Instance.CreateCoffee();
Console.WriteLine($"Espresso: {espresso.Description}");


ICoffee cappuccino = CoffeeFactory.Instance.CreateCoffee("Cappuccino");
Console.WriteLine($"Cappuccino: {cappuccino.Description}");


ICoffee flatWhite = CoffeeFactory.Instance.CreateCoffee("FlatWhite");
Console.WriteLine($"Flat White: {flatWhite.Description}");


ICoffee custom = new CustomCoffee(cappuccino, new List<string> { "Soy Milk", "Sugar" }, "Tasty Cappuccino");
Console.WriteLine($"Custom Coffee: {custom.Description}");