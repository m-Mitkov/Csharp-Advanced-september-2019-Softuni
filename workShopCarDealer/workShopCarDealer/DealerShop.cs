using System.Collections;
using System.Collections.Generic;

namespace workShopCarDealer
{
    public class DealerShop : IEnumerable<Vehichle>
    {
        private List<Vehichle> vehicles;
       // private Dictionary<string, int> vehicleSold;
       // private Dictionary<string, int> totalVehicles;

        public DealerShop(string name, string location)
        {
            this.NameShop = name;
            this.Location = location;
            this.vehicles = new List<Vehichle>();
           // this.vehicleSold = new Dictionary<string, int>();
           // this.totalVehicles = new Dictionary<string, int>();
        }
        public string NameShop { get; set; }
        public string Location { get; set; }

        public void AddCar(Vehichle vehicle)
        {
            this.vehicles.Add(vehicle);
           // this.totalVehicles.Add(this.NameShop, ++);
        }

        public Vehichle SellCar(string brand, string model)
        {
            Vehichle vehicleToSell = null;
            foreach (var vehicle in this.vehicles)
            {
                if (vehicle.Brand == brand && vehicle.Model == model)
                {
                    vehicleToSell = vehicle;
                }
            }
            vehicles.Remove(vehicleToSell);
            return vehicleToSell;
        }

        public Vehichle GetInformationAboutVehicle(string brand, string model)
        {
            Vehichle vehicleToReturn = null;

            foreach (var vehicle in this.vehicles)
            {
                if (vehicle.Brand == brand && vehicle.Model == model)
                {
                    vehicleToReturn = vehicle;
                }
            }

            return vehicleToReturn;
        }

        public Engine GetInformationAboutEngine(string carBrand, string carModel)
        {
            Engine engineToReturn = null;

            foreach (var vehicle in this.vehicles)
            {
                if (vehicle.Brand == carBrand && vehicle.Model == carModel)
                {
                    engineToReturn = vehicle.Engine;
                }
            }

            return engineToReturn;
        }

        public FuelConsumption GetFuelConsumption(string brandCar, string modelEngine) 
        {
            FuelConsumption fuelConsumptionToReturn = null;

            foreach (var vehicle in this.vehicles)
            {
                if (vehicle.Brand == brandCar && vehicle.Engine.EngineModel == modelEngine)
                {
                    fuelConsumptionToReturn = vehicle.Engine.FuelConsumption;
                }
            }

            return fuelConsumptionToReturn;
        }

        public IEnumerator<Vehichle> GetEnumerator()
        {
            foreach (var car in vehicles)
            {
                yield return car;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
