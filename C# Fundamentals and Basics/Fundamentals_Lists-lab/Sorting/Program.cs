using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////Selection sort
            List<int> list = new List<int>() { 4, 3, 2, 1 };
            for (int i = 0; i < list.Count; i++)
            {
                int min = list[i];
                int minIndex = i;
                for (int j = i; j < list.Count; j++)
                {
                    if(list[j] < min)
                    {
                        min = list[j];
                        minIndex = j;
                    }
                }
                int temp = list[i];
                list[i] = list[minIndex];
                list[minIndex] = temp;
            }
            Console.WriteLine(string.Join(" ", list));


            /////////Bubble sort
            List<int> list2 = new List<int>() { 4, 3, 2, 1 };
            for (int i = 0; i < list2.Count; i++)
            {
                for (int j = i+1; j < list2.Count; j++)
                {
                    if(list2[i] > list2[j])
                    {
                        int temp = list2[i];
                        list2[i] = list2[j];
                        list2[j] = temp; 
                    }
                }
            }


            Console.WriteLine(string.Join(" ", list2));



            
        }
    }
}
