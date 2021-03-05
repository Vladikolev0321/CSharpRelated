 using System;
using System.Collections.Generic;

namespace SortingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
           {  1,-1,3,645,34,233};
            Console.WriteLine(string.Join(" ", list));
            list.Sort();
            Console.WriteLine(string.Join(" ", list));
            list.Reverse();
            Console.WriteLine(string.Join(" ", list));

        }
    }
}
