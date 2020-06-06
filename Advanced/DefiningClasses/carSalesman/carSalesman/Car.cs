using System;
using System.Collections.Generic;
using System.Text;

namespace carSalesman
{
   public class Car
    {
        public Car(string model, Engine engine, int weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }
        public Car(string model, Engine engine, int weight)
            : this(model, engine, weight, "n/a")
        {
        }
        public Car(string model, Engine engine, string color)
            : this(model, engine, -1, color)
        {
        }
        public Car(string model, Engine engine) : this(model, engine, -1, "n/a")
        {
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
        public override string ToString()
        {
            StringBuilder returnCarInformation = new StringBuilder();

            string engineDisplacement = this.Engine.Displacement != -1
                ? this.Engine.Displacement.ToString()
                : "n/a";

            string carWeight = this.Weight != -1
                ? this.Weight.ToString()
                : "n/a";

            returnCarInformation.AppendLine($"{this.Model}:");
            returnCarInformation.AppendLine($" {this.Engine.Model}:");
            returnCarInformation.AppendLine($"  Power: {this.Engine.Power}");
            returnCarInformation.AppendLine($"  Displacement: {engineDisplacement}");
            returnCarInformation.AppendLine($"  Efficiency: {this.Engine.Efficiency}");
            returnCarInformation.AppendLine($" Weight: {carWeight}");
            returnCarInformation.Append($" Color: {this.Color}");

            return returnCarInformation.ToString();
        }
    }
}
