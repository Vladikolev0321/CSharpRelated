using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._The_Fight_for_Gondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int countWaves = int.Parse(Console.ReadLine());
            Queue<int> plates = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            bool isDestr = false;

            for (int i = 1; i <= countWaves; i++)
            {
                Stack<int> orcs = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
                if (i % 3 == 0)
                {
                    plates.Enqueue(int.Parse(Console.ReadLine()));
                }

                while (orcs.Any() && plates.Any())
                {
                    if (orcs.Peek() > plates.Peek())
                    {
                        orcs.Push(orcs.Pop() - plates.Peek());
                        plates.Dequeue();
                        if (orcs.Peek() <= 0)
                        {
                            orcs.Pop();
                        }
                    }
                    else if (orcs.Peek() < plates.Peek())
                    {
                        plates.Enqueue(plates.Dequeue() - orcs.Peek());
                        for (int j = 0; j < plates.Count-1; j++)
                        {
                            plates.Enqueue(plates.Dequeue());
                        }
                        orcs.Pop();
                    }
                    else if (orcs.Peek() == plates.Peek())
                    {
                        orcs.Pop();
                        plates.Dequeue();
                    }
                }
                if (!plates.Any())
                {

                    Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                    isDestr = true;
                    if (orcs.Any())
                    {
                        Console.WriteLine($"Orcs left: {string.Join(", ", orcs)}");
                    }
                    break;
                }
            }


            
            if (!isDestr)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
            }
            if (plates.Any())
            {
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }

        }
    }
}
