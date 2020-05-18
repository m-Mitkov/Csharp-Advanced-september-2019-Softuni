using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace workShopCarDealer
{
    public class Engine
    {
        public Engine()
        {

        }

        public Engine(string engineModel, double cubicMeters, string typeFuel, 
            Gearbox gearbox, FuelConsumption fuelConsumption)
        {
            this.EngineModel = engineModel;
            this.CubicMeters = cubicMeters;
            this.TypeOfFuel = typeFuel;
            this.Gearbox = gearbox;
            this.FuelConsumption = fuelConsumption;
        }
        public string EngineModel { get; set; }
        public double CubicMeters { get; set; }
        public string TypeOfFuel { get; set; }
        public Gearbox Gearbox { get; set; }
        public FuelConsumption FuelConsumption { get; set; }

        public override string ToString()
        {
            StringBuilder engineInformation = new StringBuilder();

            engineInformation.AppendLine($"Engine model: {this.EngineModel}");
            engineInformation.AppendLine($"Cubic meters: {this.CubicMeters:F2}");
            engineInformation.AppendLine($"Type of fuel: {this.TypeOfFuel}");

            return engineInformation.ToString().TrimEnd();
        }
    }
}
