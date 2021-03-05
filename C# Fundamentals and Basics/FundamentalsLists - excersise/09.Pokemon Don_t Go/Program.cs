using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> removedList = new List<int>();

            while (list.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                if (index < 0)
                { 
                    removedList.Add(list[0]);
                    int removed = list[0];
                   // index = 0;
                    list.RemoveAt(0);                  
                    list.Insert(0, list[list.Count - 1]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        //if (i == index)
                        //{
                        //    continue;
                        //}
                        if (list[i] <= removed)
                        {
                            list[i] += removed;
                        }
                        else if (list[i] > removed)
                        {
                            list[i] -= removed;
                        }
                    }
                    continue;
                    //
                }
                else if(index > list.Count - 1)
                {
                    removedList.Add(list[list.Count - 1]);
                    int removed = list[list.Count - 1];
                   // index = 
                    list.RemoveAt(list.Count - 1);
                    list.Add(list[0]);

                    for (int i = 0; i < list.Count; i++)
                    {
                        //if (i == index)
                        //{
                        //    continue;
                        //}
                        if (list[i] <= removed)
                        {
                            list[i] += removed;
                        }
                        else if (list[i] > removed)
                        {
                            list[i] -= removed;
                        }
                    }
                    continue;

                    //
                }
                else{
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i == index)
                        {
                            continue;
                        }
                        if (list[i] <= list[index])
                        {
                            list[i] += list[index];
                        }
                        else if (list[i] > list[index])
                        {
                            list[i] -= list[index];
                        }
                    }
                    removedList.Add(list[index]);
                list.RemoveAt(index);
                }
                
                
            }
            Console.WriteLine(removedList.Sum());
        }
    }
}
