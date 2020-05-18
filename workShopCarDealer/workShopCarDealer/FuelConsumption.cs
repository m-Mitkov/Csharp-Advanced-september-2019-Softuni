using System.Text;

namespace workShopCarDealer
{
    public class FuelConsumption
    {
        public FuelConsumption()
        {

        }

        public FuelConsumption(double city, double highway, double averge)
        {
            this.City = city;
            this.Highway = highway;
            this.Average = averge;
        }
        public double City { get; set; }
        public double Highway { get; set; }
        public double Average { get; set; }

        public override string ToString()
        {
            StringBuilder returnInformation = new StringBuilder();

            returnInformation.AppendLine($"City consumption: {this.City:F2}");
            returnInformation.AppendLine($"Highway consumption: {this.Highway:F2}");
            returnInformation.AppendLine($"Average consumption: {this.Average:F2}");

            return returnInformation.ToString().TrimEnd();
        }
    }
}
