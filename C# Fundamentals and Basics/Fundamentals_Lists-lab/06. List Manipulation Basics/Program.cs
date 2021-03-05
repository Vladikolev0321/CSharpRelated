using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
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
                else if(command[0] == "Remove")
                {
                    list.Remove(int.Parse(command[1]));
                }
                else if(command[0] == "RemoveAt")
                {
                    list.RemoveAt(int.Parse(command[1]));
                }
                else
                {
                    list.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
