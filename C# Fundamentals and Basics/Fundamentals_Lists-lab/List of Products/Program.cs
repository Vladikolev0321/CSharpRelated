using System;
using System.Collections.Generic;

namespace List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int n = int.Parse(Console.ReadLine());
            list = AddProductsAndSort(list, n);
            for (int i = 0; i < n ; i++)
            {
                Console.WriteLine($"{i + 1}.{list[i]}");
            }
        }
        static List<string> AddProductsAndSort(List<string> list, int n)
        {
            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                list.Add(product);
            }
            list.Sort();
            return list;
        }
    }
}
