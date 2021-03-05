using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Car
    {
        public Car(string make, string model, int horsePower, string registrationNum)
        {
            this.Make = make;
            this.Model = model;
            this.HorsePower = horsePower;
            this.RegistrationNumber = registrationNum;
        }
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int HorsePower { get; private set; }
        public string RegistrationNumber { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine($"Make: {this.Make}")
                .AppendLine($"Model: {this.Model}")
                .AppendLine($"HorsePower: {this.HorsePower}")
                .AppendLine($"RegistrationNumber: {this.RegistrationNumber}");

            return sb.ToString().TrimEnd();

        }

    }
}
