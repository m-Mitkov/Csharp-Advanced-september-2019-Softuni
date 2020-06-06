using System;
using System.Collections.Generic;
using System.Linq;

namespace carSalesman
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            FindAllEngines(engines);
            FindAllCars(cars, engines);

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
        public static void FindAllEngines(List<Engine> engines)
        {
            int numberOfEngines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] currentEngine = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = currentEngine[0];
                int power = int.Parse(currentEngine[1]);

                if (currentEngine.Length == 4)
                {
                    int displacement = int.Parse(currentEngine[2]);
                    string efficiency = currentEngine[3];

                    Engine engine = new Engine(model, power, displacement, efficiency);
                    engines.Add(engine);
                }

                if (currentEngine.Length == 3)
                {
                    int displacement = 0;
                    bool isDisplcement = int.TryParse(currentEngine[2], out displacement);

                    if (isDisplcement)
                    {
                        Engine engine = new Engine(model, power, displacement);
                        engines.Add(engine);
                    }

                    else
                    {
                        string efficieny = currentEngine[2];

                        Engine engine = new Engine(model, power, efficieny);
                        engines.Add(engine);
                    }
                }

                else if (currentEngine.Length == 2)
                {
                    Engine engine = new Engine(model, power);
                    engines.Add(engine);
                }
            }
        }
        public static void FindAllCars(List<Car> cars, List<Engine> engines)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] currentCar = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = currentCar[0];
                Engine engine = engines.FirstOrDefault(x => x.Model == currentCar[1]);

                if (currentCar.Length == 4)
                {
                    int weight = int.Parse(currentCar[2]);
                    string color = currentCar[3];

                    Car car = new Car(model, engine, weight, color);
                    cars.Add(car);
                }

                else if (currentCar.Length == 3)
                {
                    int weight = 0;
                    bool isWeight = int.TryParse(currentCar[2], out weight);

                    if (isWeight)
                    {
                        weight = int.Parse(currentCar[2]);

                        Car car = new Car(model, engine, weight);
                        cars.Add(car);
                    }

                    else
                    {
                        string color = currentCar[2];

                        Car car = new Car(model, engine, color);
                        cars.Add(car);
                    }
                }

                else if (currentCar.Length == 2)
                {
                    Car car = new Car(model, engine);
                    cars.Add(car);
                }
            }
        }
    }
}
