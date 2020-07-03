using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public abstract class Vehicle
    {
        protected double fuelQuantity;
        protected double fuelConsumption;
        protected double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.fuelQuantity = fuelQuantity <= tankCapacity ? fuelQuantity : 0;
            this.fuelConsumption = fuelConsumption;
            this.tankCapacity = tankCapacity;
        }

        public double FuelLeft => this.fuelQuantity;

        public virtual string Drive(double distance)
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
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (liters + this.fuelQuantity > this.tankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }

            this.fuelQuantity += liters;
        }
    }
}
