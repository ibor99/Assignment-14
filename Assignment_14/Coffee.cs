using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_14
{
    public abstract class Coffee
    {
        public int BlackCoffeeShots { get; set; }
        public Milk Milk { get; set; }
        public Sugar Sugar { get; set; }
    }
}
