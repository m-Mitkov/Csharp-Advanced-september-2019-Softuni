using System;
using System.Collections.Generic;
using System.Text;

 namespace speedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double traveledDistance;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(int kilometersToDrive)
        {
            if (IsFuelEnough(kilometersToDrive))
            {
                this.TravelledDistance += kilometersToDrive;
                this.FuelAmount -= kilometersToDrive * this.FuelConsumptionPerKilometer;
            }

            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }

        private bool IsFuelEnough(int kilometersToDrive)
        {
            return this.FuelAmount >= (kilometersToDrive * this.FuelConsumptionPerKilometer);
        }
    }
}
