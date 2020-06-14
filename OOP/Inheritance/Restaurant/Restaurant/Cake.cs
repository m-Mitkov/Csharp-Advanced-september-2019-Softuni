using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Cake : Dessert
    {
        public Cake(string name)
            : base(name, 5, 250, 1000)
        {
        }
        public Cake(string name, decimal price, double grams, double calories)
            : base(name, price, grams, calories)
        {
        }
    }
}
