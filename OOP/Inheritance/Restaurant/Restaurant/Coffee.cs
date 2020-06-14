using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Coffee : HotBeverage
    {
        public Coffee(string name)
            : base(name, 3.5M, 50)
        {
            this.Name = name;
            this.Price = CoffeePrice;
            this.Milliliters = CoffeeMilliliters;
        }
        public Coffee(double cafeine, string name, decimal price, double mililiters)
            : base(name, price, mililiters)
        {
            this.Caffeine = cafeine;
            this.Milliliters = CoffeeMilliliters;
            this.Price = CoffeePrice;
        }
        public double Caffeine { get; set; }
        public double CoffeeMilliliters { get; } = 50;
        public decimal CoffeePrice { get; } = 3.50M;
    }
}
