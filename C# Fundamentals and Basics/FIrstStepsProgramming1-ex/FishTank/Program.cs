using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int obem = lenght * width * height;
            double capacity = obem * 0.001;
            percent = percent * 0.01;
            double litriRealnoShteTrqbvatZaPrepulvane = capacity * (1 - percent);

            Console.WriteLine(litriRealnoShteTrqbvatZaPrepulvane);

        }
    }
}
