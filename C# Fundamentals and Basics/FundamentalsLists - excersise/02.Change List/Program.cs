using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Change_List
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
                switch (command[0])
                {
                    case "Delete":
                        int num = int.Parse(command[1]);
                        for (int i = 0; i < list.Count; i++)
                        {
                            if(list[i] == num)
                            {
                                list.Remove(list[i]);
                                i--;
                            }
                        }
                        break;
                    case "Insert":
                        int number = int.Parse(command[1]);
                        int index  = int.Parse(command[2]);
                        list.Insert(index, number);
                        break;
                }

            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
