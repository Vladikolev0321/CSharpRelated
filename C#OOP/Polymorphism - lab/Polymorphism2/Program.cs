using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle vehicle = new Airplane();


            Vehicle airplane = new Airplane();
            Vehicle truck = new Truck();

            //PrintVehicleModel(airplane);
            //PrintVehicleModel(truck);

            var vehicles = new List<IVehicle> { airplane, truck, new Ship()};

            PrintVrumVrum(airplane);
            PrintVrumVrum(truck);
            PrintVrumVrum(new AirFighter());
            PrintVrumVrum(new CatOnJet());

            var anotherAirplane = new Airplane();

            Console.WriteLine(anotherAirplane.VrumVrum(10));
            
             
        }
        public static void PrintVrumVrum(Vehicle vehicle)
        {
            //if(vehicle is Airplane airplane)////Bad way of doing
            //{
            //    Console.WriteLine(airplane.VrumVrum());
            //}
            //else if(vehicle is CatOnJet catOnJet)
            //{
            //    Console.WriteLine(catOnJet.VrumVrum());
            //}
            Console.WriteLine(vehicle.VrumVrum());


        }

        public static void PrintVehicleModel(Vehicle vehicle)
        {
            Console.WriteLine(vehicle.Model);
        }
    }
}
