using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();
            PlayGame(first, second);
        }
        static void PlayGame(List<int> first, List<int> second)
        {
            int i = 0;
            while(first.Count > 0  && second.Count > 0)
            {
                if(first[i] > second[i])
                {
                    first.Add(first[i]);
                    first.Add(second[i]);
                    first.RemoveAt(i);
                    second.RemoveAt(i);
                    i--;
                }
                else if(second[i] > first[i])
                {
                    second.Add(second[i]);
                    second.Add(first[i]);
                    second.RemoveAt(i);
                    first.RemoveAt(i);
                    i--;
                }
                else
                {
                    first.RemoveAt(i);
                    second.RemoveAt(i);
                    i--;
                }


                i++;
            }

            if (first.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {first.Sum()}");
            }
            else if(second.Count > 0)
            {
                Console.WriteLine($"Second player wins! Sum: {second.Sum()}");
            }
        }
    }
}
