using P01.Vehicles.Core;
using System;

namespace P01.Vehicles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Run();
        }
    }
}
