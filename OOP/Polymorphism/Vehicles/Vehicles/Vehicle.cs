using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    abstract class Vehicle
    {
        private const double consumptionIncreasedAC = 0;
        private const double percentageLostFuel = 0;

        private double fuelQuantity;
        private double fuelConsumption;

        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get => this.fuelQuantity;
            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("Fuel quantity cannot be negative number!");
                }

                this.fuelQuantity = value;
            }
        }

        public double FuelConsumption => fuelConsumption;

        public string Drive(double distance)
        {
            double consumedFuelTrip = this.fuelConsumption * distance;

            if (this.fuelQuantity >= consumedFuelTrip)
            {
                this.fuelQuantity -= consumedFuelTrip;

                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public virtual void Refuel(double liters)
        {
            this.fuelQuantity += liters;
        }
    }
}
