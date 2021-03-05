using System;
using System.Collections.Generic;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, int> dictionary = new Dictionary<int, int>();
            //dictionary.Add(1, 10);
            //dictionary.Add(2, 10);
            //foreach (var (key,value) in dictionary)
            //{
            //    Console.WriteLine(key + " "+ value);
            //}
            /////Other type of dcitionary
            ///
           var  townWithNeighbourHoods = new Dictionary<string, List<string>>();

            townWithNeighbourHoods.Add("Sofia", new List<string>());
            townWithNeighbourHoods["Sofia"].Add("Vitosha");
            townWithNeighbourHoods["Sofia"].Add("Gerena");

            foreach (var town in townWithNeighbourHoods)
            {
                Console.WriteLine(town.Key);
                foreach (var kvartal in town.Value)
                {
                    Console.WriteLine(kvartal);
                }
            }
        }
    }
}
