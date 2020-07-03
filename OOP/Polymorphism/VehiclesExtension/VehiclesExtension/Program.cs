using System;

namespace VehiclesExtension
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string[] carInput = Console.ReadLine()
           .Split(" ");

            double fuelQuantityCar = double.Parse(carInput[1]);
            double fuelConsumptionCar = double.Parse(carInput[2]);
            double tankCapacityCar = double.Parse(carInput[3]);
            Car car = new Car(fuelQuantityCar, fuelConsumptionCar, tankCapacityCar);

            string[] truckInput = Console.ReadLine()
                .Split(" ");

            double fuelQuantityTruck = double.Parse(truckInput[1]);
            double fuelConsumptionTruck = double.Parse(truckInput[2]);
            double tankCapacityTruck = double.Parse(truckInput[3]);
            Truck truck = new Truck(fuelQuantityTruck, fuelConsumptionTruck, tankCapacityTruck);

            string[] busInput = Console.ReadLine()
                .Split(" ");

            double fuelQuantityBus = double.Parse(busInput[1]);
            double fuelConsumptionBus = double.Parse(busInput[2]);
            double tankCapacityBus = double.Parse(busInput[3]);
            Bus bus = new Bus(fuelQuantityBus, fuelConsumptionBus, tankCapacityBus);

            int numberOfComandToFollow = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfComandToFollow; i++)
            {
                try
                {
                    string[] command = Console.ReadLine()
                        .Split(" ");

                    if (command[0] == "Drive")
                    {
                        if (command[1] == "Car")
                        {
                            Console.WriteLine(car.Drive(double.Parse(command[2])));
                        }

                        else if (command[1] == "Truck")
                        {
                            Console.WriteLine(truck.Drive(double.Parse(command[2])));
                        }

                        else
                        {
                            Console.WriteLine(bus.DriveBusWithPeople(double.Parse(command[2])));
                        }
                    }
                    else if (command[0] == "Refuel")
                    {
                        if (command[1] == "Car")
                        {
                            car.Refuel(double.Parse(command[2]));
                        }

                        else if (command[1] == "Truck")
                        {
                            truck.Refuel(double.Parse(command[2]));
                        }

                        else
                        {
                            bus.Refuel(double.Parse(command[2]));
                        }
                    }

                    else
                    {
                        Console.WriteLine(bus.Drive(double.Parse(command[2])));
                    }
                }

                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"Car: {car.FuelLeft:F2}");
            Console.WriteLine($"Truck: {truck.FuelLeft:F2}");
            Console.WriteLine($"Bus: {bus.FuelLeft:F2}");

        }
    }
}

