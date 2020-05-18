using System.Text;

namespace workShopCarDealer
{
    public class Gearbox
    {
        public Gearbox()
        {

        }
        public Gearbox(string type, int numberOfGears)
        {
            this.Type = type;
            this.NumberOfGears = numberOfGears;
        }
        public string Type { get; set; }  // automatic / manual
        public int NumberOfGears { get; set; }

        public override string ToString()
        {
            StringBuilder returnInformation = new StringBuilder();

            returnInformation.AppendLine($"Type of gearbox: {this.Type}");
            returnInformation.AppendLine($"Number of gears: {this.NumberOfGears}");

            return returnInformation.ToString().TrimEnd();
        }
    }
}
