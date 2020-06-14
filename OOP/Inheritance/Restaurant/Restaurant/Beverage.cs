﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Beverage : Product
    {
        public Beverage(string name, decimal price, double mililiters)
            : base(name, price)
        {
            this.Milliliters = mililiters;
        }

        public virtual double Milliliters { get; set; }
    }
}
