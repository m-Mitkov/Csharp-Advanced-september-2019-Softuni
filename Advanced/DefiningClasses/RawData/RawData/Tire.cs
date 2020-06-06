using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {
        public Tire(double tirePreasure, int tireAge)
        {
            this.TirePreassure = tirePreasure;
            this.TireAge = tireAge;
        }
        public double TirePreassure { get; set; }
        public int TireAge { get; set; }
    }
}
