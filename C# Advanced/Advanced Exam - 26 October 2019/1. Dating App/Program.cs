using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] malesInput = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] femalesInput = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> males = new Stack<int>(malesInput);
            Queue<int> females = new Queue<int>(femalesInput);

            int succesfullMatches = 0;

            while(males.Any() && females.Any())
            {
                int currMale = males.Peek();
                int currFemale = females.Peek();

                if(currMale <= 0)
                {
                    males.Pop();
                    continue;
                }
                if(currFemale <= 0)
                {
                    females.Dequeue();
                    continue;
                }
                if(currMale % 25 == 0)
                {
                    males.Pop();
                    males.Pop();
                    continue;
                }
                if(currFemale % 25 == 0)
                {
                    females.Dequeue();
                    females.Dequeue();
                    continue;
                }
                if(currMale == currFemale)
                {
                    males.Pop();
                    females.Dequeue();
                    succesfullMatches++;
                }
                else
                {
                    females.Dequeue();
                    int decreasedMale = males.Pop() - 2;
                    males.Push(decreasedMale);
                }
            }


            Console.WriteLine($"Matches: {succesfullMatches}");
            if (males.Any())
            {
                Console.WriteLine($"Males left: {string.Join(", ",males)}");
            }
            else
            {
                Console.WriteLine("Males left: none");
            }
            if (females.Any())
            {
                Console.WriteLine($"Females left: {string.Join(", ", females)}");
            }
            else
            {
                Console.WriteLine("Females left: none");
            }


        }
    }
}
