using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
        //    List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();
        //    List<int> result = new List<int>();
        //    result = MergeLists(first, second);
        //    Console.WriteLine(string.Join(" ", result));
        //}
        //static List<int> MergeLists(List<int> first, List<int> second)
        //{
        //    int count = Math.Max(first.Count, second.Count);
        //    List<int> newList = new List<int>();

        //    for (int i = 0; i < count; i++)
        //    {
        //        if( i < first.Count)
        //        {
        //            newList.Add(first[i]);
        //        }
        //        if (i < second.Count)
        //        {
        //            newList.Add(second[i]);
        //        }

        //    }
        //    return newList;

        //}
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = MergeLists(first, second);
            Console.WriteLine(string.Join(" ", result));
        }

        static List<int> MergeLists(List<int> first , List<int> second)
        {
            List<int> newList = new List<int>();
            int countNew = Math.Max(first.Count, second.Count);
            for (int i = 0; i < countNew; i++)
            {
                if(i < first.Count)
                {
                    newList.Add(first[i]);
                }
                if(i < second.Count)
                {
                    newList.Add(second[i]);
                }
            }
            return newList;
        }
    }
}
