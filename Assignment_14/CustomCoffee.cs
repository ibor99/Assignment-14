using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_14
{
    class CustomCoffee : ICoffee
    {
        private readonly ICoffee _coffeeBasic;
        private readonly string _baseName;
        private readonly List<string> _extra;

        public CustomCoffee(ICoffee coffeeBasic, List<string> extra, string name)
        {
            _coffeeBasic = coffeeBasic ?? throw new ArgumentNullException(nameof(coffeeBasic));
            _baseName = name;
            _extra = extra;
        }

        public string Description
        {
            get
            {
                string description = string.Empty;
                
                description = _coffeeBasic.Name;

                foreach (var item in _extra)
                {
                    description += " + " + item;
                }
                return description;
            }
        }

        public string Name => _baseName;
    }
}
