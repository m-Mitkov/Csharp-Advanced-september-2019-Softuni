using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Truck : Vehicle
    {
        private const double consumptionIcreasedAC = 1.6;
        private const double percentageLostFuel = 5;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption + consumptionIcreasedAC, tankCapacity)
        {
        }

        public override void Refuel(double liters)
        {
            base.Refuel(liters);
            this.fuelQuantity -= liters * (percentageLostFuel / 100);
        }
    }
}
