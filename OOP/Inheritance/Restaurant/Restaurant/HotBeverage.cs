using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class HotBeverage : Beverage
    {
        public HotBeverage(string name, decimal price, double mililiters)
            : base(name, price, mililiters)
        {
        }
    }
}
