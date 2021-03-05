using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i].ToLower();
                if (!counts.ContainsKey(word))
                {
                    counts[word] = 1;
                }
                else
                {
                    counts[word]++;
                }
            }

            foreach (var item in counts)
            {
                if(item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
                
            }
        }
    }
}
