// See https://aka.ms/new-console-template for more information
using Assignment_14;
using static Assignment_14.Milk;

CoffeeFactory coffeeFactory = new CoffeeFactory();

Coffee espresso = coffeeFactory.CreateCoffee(1, new Milk { Type = MilkType.None, Quantity = 0 }, new Sugar { Quantity = 0 });
Console.WriteLine($"Created a {espresso.GetType().Name}");

Coffee cappuccino = coffeeFactory.CreateCoffee(1, new Milk { Type = MilkType.Soy, Quantity = 1 }, new Sugar { Quantity = 0 });
Console.WriteLine($"Created a {cappuccino.GetType().Name}");

Coffee flatWhite = coffeeFactory.CreateCoffee(2, new Milk { Type = MilkType.Oat, Quantity = 1 }, new Sugar { Quantity = 0 });
Console.WriteLine($"Created a {flatWhite.GetType().Name}");

Coffee customCoffee = coffeeFactory.CreateCoffee(400, new Milk { Type = MilkType.Soy, Quantity = 5 }, new Sugar { Quantity = 27 });
Console.WriteLine($"Created a {customCoffee.GetType().Name} based on {((CustomCoffee)customCoffee).BaseRecipeName} with {customCoffee.BlackCoffeeShots} Black Coffee shot(s) , {customCoffee.Milk.Quantity} shot(s) of {customCoffee.Milk.Type} Milk and {customCoffee.Sugar.Quantity} sugar(s)");