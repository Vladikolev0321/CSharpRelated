using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(5);
            list.Add(6);
            list.Add(-51);
            list.Add(33);

            //list.RemoveAt(1);
            RemoveSoftuni(list,6);
            Console.WriteLine($"list[0]={list[0]}");
            Console.WriteLine($"Count:{list.Count}");

                
        }
        static void RemoveSoftuni(List<int> list, int element)
        {
            list.Remove(element);
        }
    }
}
