using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int broiProekti = int.Parse(Console.ReadLine());

            int chasoveZaIzgotvqne = broiProekti * 3;
            Console.WriteLine($"The architect {name} will need {chasoveZaIzgotvqne} hours to complete {broiProekti} project/s.");
        }
    }
}
