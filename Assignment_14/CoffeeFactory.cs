using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment_14.Milk;

namespace Assignment_14
{
    public class CoffeeFactory
    {
        public Coffee CreateCoffee(int blackCoffeeShots, Milk milk, Sugar sugar)
        {
            if (blackCoffeeShots == 1 && milk.Type == MilkType.None && sugar.Quantity == 0 && milk.Quantity == 0)
            {
                return new Espresso();
            }
            else if (blackCoffeeShots == 2 && milk.Type != MilkType.None && sugar.Quantity == 0 && milk.Quantity == 1)
            {
                return new FlatWhite();
            }
            else if (blackCoffeeShots == 1 && milk.Type != MilkType.None && sugar.Quantity == 0 && milk.Quantity == 1)
            {
                return new Cappuccino();
            }
            else
            {
                var customedCoffee = new CustomCoffee
                {
                    BlackCoffeeShots = blackCoffeeShots,
                    Milk = new Milk {                         Type = milk.Type,
                                           Quantity = milk.Quantity
                                       },
                    Sugar = new Sugar { Quantity = sugar.Quantity }
                };

                if (blackCoffeeShots == 1 && milk.Type != MilkType.None)
                {
                    customedCoffee.BaseRecipeName = "Cappuccino";
                }
                else if (blackCoffeeShots == 2 && milk.Type != MilkType.None)
                {
                    customedCoffee.BaseRecipeName = "Flat White";
                }
                else
                {
                    customedCoffee.BaseRecipeName = "Espresso";
                }

                return customedCoffee;

            }
        }
    }
}
