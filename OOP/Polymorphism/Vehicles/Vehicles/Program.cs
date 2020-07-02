using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carInput = Console.ReadLine()
                .Split(" ");

            double fuelQuantityCar = double.Parse(carInput[1]);
            double fuelConsumptionCar = double.Parse(carInput[2]);
            Car car = new Car(fuelQuantityCar, fuelConsumptionCar);

            string[] truckInput = Console.ReadLine()
                .Split(" ");

            double fuelQuantityTruck = double.Parse(truckInput[1]);
            double fuelConsumptionTruck = double.Parse(truckInput[2]);
            Truck truck = new Truck(fuelQuantityTruck, fuelConsumptionTruck);

            int numberOfComandToFollow = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfComandToFollow; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ");

                if (command[0] == "Drive")
                {
                    if (command[1] == "Car")
                    {
                        Console.WriteLine(car.Drive(double.Parse(command[2])));
                    }
                    else
                    {
                        Console.WriteLine(truck.Drive(double.Parse(command[2])));
                    }
                }
                else
                {
                    if (command[1] == "Car")
                    {
                        car.Refuel(double.Parse(command[2]));
                    }
                    else
                    {
                        truck.Refuel(double.Parse(command[2]));
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
        }
    }
}

