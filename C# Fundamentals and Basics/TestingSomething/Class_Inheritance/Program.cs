using System;

namespace Class_Inheritance
{
    ///sealed class Vehicle /// doesn't allow this class to be inherited - sealed 
     class Vehicle
    {
        public string brand = "Ford";
        public void honk()
        {
            Console.WriteLine("BEEP BEEP");
        }

    }
    class Car : Vehicle
    {
        public string modelName = "Mustang";

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.honk();
            Console.WriteLine($"{myCar.brand} {myCar.modelName}");
           
        }
    }
}
