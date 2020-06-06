using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Car
    {
        public Car(string make, string model, int horsePower, string registration)
        {
            this.Make = make;
            this.Model = model;
            this.HorsePower = horsePower;
            this.RegistrationNumber = registration;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        public override string ToString()
        {
            StringBuilder returnInformation = new StringBuilder();

            returnInformation.AppendLine($"Make: {this.Make}");
            returnInformation.AppendLine($"Model: {this.Model}");
            returnInformation.AppendLine($"HorsePower: {this.HorsePower}");
            returnInformation.AppendLine($"RegistrationNumber: {this.RegistrationNumber}");

            return returnInformation.ToString().Trim();
        }
    }
}
