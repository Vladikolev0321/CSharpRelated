using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] bottlesInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> cups = new Queue<int>(cupsInfo);
            Stack<int> bottles = new Stack<int>(bottlesInfo);

            int wastedWater = 0;
            while(cups.Any() && bottles.Any())
            {
                int currCup = cups.Peek();
                int currBottle = bottles.Pop();
                if (currBottle >= currCup)
                {
                    cups.Dequeue();
                    wastedWater += currBottle - currCup;
                }
                else
                {
                    currCup -= currBottle;
                    cups.Dequeue();
                    // cups.Enqueue(currCup);
                    while (true)
                    {
                        int nowBottle = bottles.Pop();
                        if (nowBottle < currCup)
                        {
                            currCup -= nowBottle;
                        }
                        else
                        {
                            wastedWater += nowBottle - currCup;
                            break;
                        }
                    }
                }
            }

            if (!cups.Any())
            {
                Console.WriteLine($"Bottles: {string.Join(" ",bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
