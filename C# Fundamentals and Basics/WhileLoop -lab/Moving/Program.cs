using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeWidth = int.Parse(Console.ReadLine());
            int freeLength = int.Parse(Console.ReadLine());
            int freeHeight = int.Parse(Console.ReadLine());

            int size = freeHeight * freeLength * freeWidth;
            int sum = 0;
            bool overSize = false;

            string command = Console.ReadLine();
            while(command != "Done")
            {
                int neededSpace = int.Parse(command);
                sum += neededSpace;
                if(sum > size)
                {
                    overSize = true;
                    break;
                }
                command = Console.ReadLine();
            }
            if (overSize)
            {
                Console.WriteLine($"No more free space! You need {sum - size} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{size - sum } Cubic meters left.");
            }
        }
    }
}
