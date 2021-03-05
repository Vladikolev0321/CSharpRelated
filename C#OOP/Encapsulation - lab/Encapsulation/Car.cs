using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Car
    {
        public Car(string make,string model)//////immutable 
        {
            this.Make = make;
            this.Model = model;
        }
        public string Model { get; }
        public string Make { get; }
    }
}
