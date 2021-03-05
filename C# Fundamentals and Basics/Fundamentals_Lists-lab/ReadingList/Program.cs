using System;
using System.Collections.Generic;

namespace ReadingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int n = int.Parse(Console.ReadLine());
            ReadList(list, n);
            PrintList(list);
           
        }
        static void PrintList(List <int> list)
        {
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            Console.WriteLine(string.Join(" ", list));
        }
        static void ReadList(List<int> list, int n)
        {
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            
            
            //return array;
        }
    }
}
