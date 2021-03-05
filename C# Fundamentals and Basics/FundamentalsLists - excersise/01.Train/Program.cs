using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "end")
                {
                    break;
                }
                string[] command = input.Split();
                if(command[0] == "Add")
                {
                    list.Add(int.Parse(command[1]));
                }
                else
                {
                    int passeng = int.Parse(command[0]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if(list[i]+passeng <= maxCapacity)
                        {
                            list[i] += passeng;
                            break;
                        }
                    }
                }
                
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
