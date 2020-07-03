using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    class Bus : Vehicle
    {
        private const double consumptionIcreasedAC = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }
        public virtual string DriveBusWithPeople(double distance)
        {
            base.fuelConsumption += consumptionIcreasedAC;
            return base.Drive(distance);
        }
    }
}
