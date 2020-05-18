using System.Text;

namespace workShopCarDealer
{
    public class Vehichle
    {
        //private Engine engine;
        //private Gearbox gearbox;
        //private FuelConsumption fuelConsumption;

        public Vehichle(string brand, string model, int year, string type,
            Engine engine) //Gearbox gearbox, //FuelConsumption fuel)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Type = type;
            this.Engine = engine;
           // this.GearBox = gearbox;
           // this.FuelConsumption = fuel;
        }
        public Engine Engine { get; set; }
      //  public Gearbox GearBox { get; set; }
      //  public FuelConsumption FuelConsumption { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Type { get; set; } // SUV, Sedan, Minivan etc.

        public override string ToString()
        {
            StringBuilder returnInformation = new StringBuilder();

            returnInformation.AppendLine($"Brand: {this.Brand}");
            returnInformation.AppendLine($"Model: {this.Model}");
            returnInformation.AppendLine($"Year: {this.Year}");
            returnInformation.AppendLine($"Coupe type: {this.Type}");
            returnInformation.AppendLine($"Engine model: {this.Engine.EngineModel}");
            returnInformation.AppendLine($"Gearbox: {this.Engine.Gearbox.Type}");
            returnInformation.AppendLine($"Average fuel consumption: {this.Engine.FuelConsumption.Average}");

            return returnInformation.ToString().TrimEnd();
        }
    }
}
