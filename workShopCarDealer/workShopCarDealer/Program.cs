using System;
using System.Linq;
using System.Collections.Generic;

namespace workShopCarDealer
{
    class Program
    {
        static void Main(string[] args)
        {
            DealerShop dealerShop = new DealerShop("BestCars", "Odense");

            Gearbox gearbox1 = new Gearbox("automatic", 7);
            FuelConsumption fuelConsumption1 = new FuelConsumption(9.5, 6.5, 7.0);
            Engine engine1 = new Engine("A720", 3.0, "disel", gearbox1, fuelConsumption1);
            Vehichle car1 = new Vehichle("Audi", "A7", 2020, "coupe", engine1);

            dealerShop.AddCar(car1);

            Gearbox gearbox2 = new Gearbox("manual", 6);
            FuelConsumption fuelConsumption2 = new FuelConsumption(8.0, 5.0, 6.5);
            Engine engine2 = new Engine("A717", 3.0, "petrol", gearbox2, fuelConsumption2);
            Vehichle car2 = new Vehichle("BMW", "7", 2017, "coupe", engine2);

            dealerShop.AddCar(car2);

            // Console.WriteLine(dealerShop.GetInformationAboutEngine("BMW", "7")); // true
            // Console.WriteLine(dealerShop.GetInformationAboutVehicle("Audi", "A7")); // true
            // Console.WriteLine(car2); // true
            // Console.WriteLine(dealerShop.GetFuelConsumption("BMW", "A717")); // true

            //foreach (var car in dealerShop)
            //{
            //    Console.WriteLine(car);   //true
            //}

            Console.WriteLine("Vehicle to sell:"); 
            Console.WriteLine(dealerShop.SellCar("BMW", "7")); // true

            Console.WriteLine();

            foreach (var car in dealerShop)
            {
                Console.WriteLine(car); // only Audi left 
            }
        }
    }
}
