using System;

namespace Charity_campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int dni = int.Parse(Console.ReadLine());
            int brSladkari = int.Parse(Console.ReadLine());
            int brTorti = int.Parse(Console.ReadLine());
            int brGofreti = int.Parse(Console.ReadLine());
            int brPancakes = int.Parse(Console.ReadLine());

            double sumaZaDen = (brTorti * 45 + brGofreti * 5.80 + brPancakes * 3.20)*brSladkari;
            double sumaOtCqlataKampaniq = sumaZaDen * dni;
            double sumaSledPokrivaneNaRazhodi = sumaOtCqlataKampaniq - sumaOtCqlataKampaniq / 8;

            Console.WriteLine(sumaSledPokrivaneNaRazhodi);


        }
    }
}
