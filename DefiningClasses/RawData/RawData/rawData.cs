using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInformation = Console.ReadLine()
                    .Split(" ", 6);

                string model = carInformation[0];
                int engineSpeed = int.Parse(carInformation[1]);
                int enginePower = int.Parse(carInformation[2]);
                int cargoWeight = int.Parse(carInformation[3]);
                string cargoType = carInformation[4];
                string[] tiresToString = carInformation[5].Split(" ");

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                List<Tire> tires = new List<Tire>();

                for (int tire = 1; tire < tiresToString.Length; tire+= 2)
                {
                    double tirePreasure = double.Parse(tiresToString[tire - 1]);
                    int tireAge = int.Parse(tiresToString[tire]);

                    Tire currentTire = new Tire(tirePreasure, tireAge);

                    tires.Add(currentTire);
                }

                Car car = new Car(model, engine, cargo, tires);

                cars.Add(car);
            }

            string typeOfCargo = Console.ReadLine();
            List<Car> sortedCars = new List<Car>();

            if (typeOfCargo == "fragile")
            {
                sortedCars = cars
                    .Where(x => x.Cargo.CargoType == "fragile")
                    .Where(x => x.Tires.Any(y => y.TirePreassure < 1))
                    .ToList();
            }

            else if (typeOfCargo == "flamable")
            {
                sortedCars = cars
                    .Where(x => x.Cargo.CargoType == "flamable")
                    .Where(x => x.Engine.EnginePower > 250)
                    .ToList();
            }

            foreach (var car in sortedCars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
