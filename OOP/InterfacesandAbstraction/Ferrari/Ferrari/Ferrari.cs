using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    class Ferrari : IDrivable
    {
        public Ferrari(string driver)
        {
            this.Driver = driver;
        }

        public string Driver { get; }

        public string Brakes()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Gas!";
        }
    }
}
