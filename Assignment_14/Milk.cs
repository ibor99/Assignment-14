using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_14
{
    public class Milk
    {
        public enum MilkType
        {
            Regular,
            Oat,
            Soy,
            None
        }

        public MilkType Type { get; set; }

        public int Quantity { get; set; }
    }
}
