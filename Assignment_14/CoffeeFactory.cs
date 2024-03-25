using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_14
{
    class CoffeeFactory : ICoffeeFactory
    {
        private readonly Dictionary<string, Func<ICoffee>> _coffeeRecipes;

        private CoffeeFactory() 
        {
            _coffeeRecipes = new Dictionary<string, Func<ICoffee>>();
            RegisterCoffee("Espresso", () => new BlackCoffee());
            RegisterCoffee("Cappuccino", () => new CustomCoffee(new BlackCoffee(), new List<string> { "Milk"},"Cappuccino"));
            RegisterCoffee("FlatWhite", () => new CustomCoffee(new BlackCoffee(), new List<string> { "Black Coffee", "Milk" }, "FlatWhite"));
        }

        private void RegisterCoffee(string type, Func<ICoffee> source)
        {
            _coffeeRecipes[type] = source;
        }

        public ICoffee CreateCoffee(string type) 
        {
            if(_coffeeRecipes.ContainsKey(type))
            {
                return _coffeeRecipes[type]();
            }

            throw new ArgumentException($"Unknown coffee type : {type}");
        }

        //Singleton
        private static CoffeeFactory _instance;
        public static CoffeeFactory Instance => _instance ??= new CoffeeFactory();// null coalescing if _instance is null(right side of '??=') the right side happens

        //factory
        public ICoffee CreateCoffee() => CreateCoffee("Espresso");
    }
}
