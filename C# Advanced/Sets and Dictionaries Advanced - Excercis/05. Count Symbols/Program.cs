using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
           var dict = new Dictionary<char, int>();

            char[] text = Console.ReadLine().ToCharArray();
            //string text = Console.ReadLine();

            foreach (var symbol in text)
            {
                if (!dict.ContainsKey(symbol))
                {
                    dict[symbol] = 0;
                }
                dict[symbol]++;
            }

            dict = dict
                .OrderBy(kvp => kvp.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
