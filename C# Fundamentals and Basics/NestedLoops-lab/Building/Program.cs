using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floorCount = int.Parse(Console.ReadLine());
            int apartCount = int.Parse(Console.ReadLine());

            for (int i = floorCount; i > 0; i--)
            {
                for (int j = 0; j < apartCount; j++)
                {
                    if (i == floorCount)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write($"O{i}{j} ");
                        }
                        else
                        {
                            Console.Write($"A{i}{j} ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
