using System;

namespace Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiStranici = int.Parse(Console.ReadLine());
            double procheteniZaChas = double.Parse(Console.ReadLine());
            int dniZaKoitoDaGiProchete = int.Parse(Console.ReadLine());

            double ResbroichasovedaOtdeli = (broiStranici / procheteniZaChas)/dniZaKoitoDaGiProchete;
            Console.WriteLine(ResbroichasovedaOtdeli);




        }
    }
}
