using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (!dict.ContainsKey(num))
                {
                    dict[num] = 0;
                }
                dict[num]++;
            }

            //dict = dict
            //    .Where(kvp => kvp.Value % 2 == 0)
            //    .ToDictionary(x => x.Key, y => y.Value);


            foreach (var kvp in dict)
            {
                if(kvp.Value % 2 == 0)
                {
                    Console.WriteLine(kvp.Key);
                }
            }
        }
    }
}
