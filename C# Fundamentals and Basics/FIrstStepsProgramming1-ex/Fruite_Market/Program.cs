using System;

namespace fruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double cenaQgodi = double.Parse(Console.ReadLine());
            double brBananas = double.Parse(Console.ReadLine());
            double brOranges = double.Parse(Console.ReadLine());
            double brMalini = double.Parse(Console.ReadLine());
            double brQgodi = double.Parse(Console.ReadLine());

            double cenaMalini = cenaQgodi - cenaQgodi * 0.5;
            double cenaOranges = cenaMalini - cenaMalini * 0.4;
            double cenaBananas = cenaMalini - cenaMalini * 0.8;

            double KolkoPariTrqbvat = cenaQgodi * brQgodi + cenaMalini * brMalini + cenaOranges * brOranges + cenaBananas * brBananas;

            Console.WriteLine(KolkoPariTrqbvat);
        }
    }
}
