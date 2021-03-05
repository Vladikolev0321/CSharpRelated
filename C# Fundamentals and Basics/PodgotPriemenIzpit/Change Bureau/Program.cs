using System;

namespace Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            double bit = double.Parse(Console.ReadLine());
            double chin = double.Parse(Console.ReadLine());
            double komis = double.Parse(Console.ReadLine());

            double resInLev = bit * 1168 + chin * 0.15 * 1.76;
            resInLev = resInLev-(resInLev * (komis / 100));
            double resInEvro = resInLev / 1.95;
            Console.WriteLine($"{resInEvro:F2}");
        }
    }
}
