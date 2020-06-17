using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public abstract class Buyer : IPerson
    {
        protected abstract int DefaultFood { get; }

        public string Name { get; set; }

        public int Age { get; set; }

        public int Food { get; set; }

        public void BuyFood()
        {
            this.Food += this.DefaultFood;
        }

    }
}
