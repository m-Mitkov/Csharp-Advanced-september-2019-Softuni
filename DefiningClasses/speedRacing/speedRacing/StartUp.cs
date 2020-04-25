using System;
using System.Collections.Generic;
using System.Linq;

 namespace speedRacing
{
    public class StartUp
    {
        public static void Main()
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] currentCar = Console.ReadLine()
                    .Split(" ");

                string model = currentCar[0];
                double fuelAmount = double.Parse(currentCar[1]);
                double fuelConsumptionFor1Km = double.Parse(currentCar[2]);
                double traveledDistance = 0;

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1Km);

                cars.Add(car);
            }

            while (true)
            {
                string[] comand = Console.ReadLine()
                    .Split(" ");

                if (comand[0] == "End")
                {
                    break;
                }

                string model = comand[1];
                int amountOfKm = int.Parse(comand[2]);

                Car carToDrive = cars.FirstOrDefault(x => x.Model == model);

                carToDrive.Drive(amountOfKm);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
