using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Tea : HotBeverage
    {
        public Tea(string name, decimal price, double mililiters)
            : base(name, price, mililiters)
        {
        }
    }
}
