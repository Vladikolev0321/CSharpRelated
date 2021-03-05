using System;

namespace Deposit_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposiranasuma = double.Parse(Console.ReadLine());
            int srok =int.Parse(Console.ReadLine());
            double godLihvenProcent = double.Parse(Console.ReadLine());
           // Console.WriteLine(godLihvenProcent*deposiranasuma/100);

            double res = deposiranasuma + srok * ((deposiranasuma * godLihvenProcent/100) / 12);
            Console.WriteLine(res);

        }
    }
}
