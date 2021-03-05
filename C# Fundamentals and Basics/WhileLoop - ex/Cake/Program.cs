using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int size = width * lenght;
            int sum = 0;
            //bool iseaten = false;

            while(sum < size)
            {
                string command = Console.ReadLine();
                if(command == "STOP")
                {   
                    break;
                }
                int szcake = int.Parse(command);
                sum = sum + szcake;


            }
            if(sum>=size)
            {
                Console.WriteLine($"No more cake left! You need {sum - size} pieces more.");
            }
            else
            {
                Console.WriteLine($"{size-sum} pieces are left.");
            }

        }
    }
}
