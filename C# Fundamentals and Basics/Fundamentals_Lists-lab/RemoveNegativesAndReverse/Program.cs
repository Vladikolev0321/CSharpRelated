using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            list = RemoveNegativesAndReverse(list);
            if(list.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", list));
            }

        }
        static List<int> RemoveNegativesAndReverse(List<int> list)
        {
            List<int> resList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 0)
                {
                    resList.Add(list[i]);
                }
            }
            resList.Reverse();
            return resList;
        }
    }
}
