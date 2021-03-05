using System;

namespace AccountBallance
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sum = 0;
            while(command != "NoMoreMoney")
            {
                double num = double.Parse(command);
                if(num < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    sum += num;
                    Console.WriteLine($"Increase: {num:F2}");
                }
                command = Console.ReadLine();
             
            }
            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
