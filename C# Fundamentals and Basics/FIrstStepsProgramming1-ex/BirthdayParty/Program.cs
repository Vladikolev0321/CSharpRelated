using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double naem = double.Parse(Console.ReadLine());
            double neobhodimBudget = naem + naem * 0.2 + (naem * 0.2 - naem * 0.2 * 0.45) + ( naem/3) ;

           /* Console.WriteLine(naem * 0.2);
            Console.WriteLine(naem * 0.2 - naem * 0.2 * 0.45);
            Console.WriteLine(naem/3);
            */
            Console.WriteLine(neobhodimBudget);
        }
    }
}
