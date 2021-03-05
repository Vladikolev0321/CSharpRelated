using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] command = input.Split();

                switch (command[0])
                {
                    case "Add":
                        list.Add(int.Parse(command[1]));
                        break;
                    case "Insert":
                        int num = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        if (index >= 0 && index < list.Count)
                        {
                            list.Insert(index, num);
                           
                        }
                        else
                        { 
                            Console.WriteLine("Invalid index");
                           
                        }
                        break;
                    case "Remove":
                        if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= list.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            list.RemoveAt(int.Parse(command[1]));
                        }
                        break;
                    case "Shift":
                        int times = int.Parse(command[2]);
                        if (command[1] == "left")
                        {
                            
                            for (int i = 0; i < times; i++)
                            {
                                list.Add(list[0]);
                                list.RemoveAt(0);
                            }
                        }
                        else if(command[1] == "right")
                        {
                            for (int i = 0; i < times; i++)
                            {
                                list.Insert(0, list[list.Count-1]);
                                list.RemoveAt(list.Count - 1);
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
