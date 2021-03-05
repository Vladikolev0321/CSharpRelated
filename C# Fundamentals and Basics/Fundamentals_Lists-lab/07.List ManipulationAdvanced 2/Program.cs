using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Contains":
                        DoesContain(list, int.Parse(command[1]));
                        break;
                    case "PrintEven":
                        PrintEven(list);
                        break;
                    case "PrintOdd":
                        PrintOdd(list);
                        break;
                    case "GetSum":
                        int sum = GetSum(list);
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string condition = command[1];
                        int num = int.Parse(command[2]);
                        Filter(list, condition, num);
                        break;


                }
            }

        }
        static void DoesContain(List<int> list, int number)
        {
            if (list.Contains(number))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
        static void PrintEven(List<int> list)
        {
            List<int> evenList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    evenList.Add(list[i]);
                }
            }
            Console.WriteLine(string.Join(" ", evenList));
        }
        static void PrintOdd(List<int> list)
        {
            List<int> oddList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    oddList.Add(list[i]);
                }
            }
            Console.WriteLine(string.Join(" ", oddList));
        }
        static int GetSum(List<int> list)
        {
            return list.Sum();
        }
        static void Filter(List<int> list, string condtion, int num)
        {
            //List<int> filteredList = new List<int>();


            for (int i = 0; i < list.Count; i++)
            {
                switch (condtion)
                {
                    case "<":
                        if (list[i] >= num)
                        {
                            list.Remove(list[i]);
                            i--;
                        }
                        break;

                    case ">":
                        if (list[i] <= num)
                        {
                            list.Remove(list[i]);
                            i--;
                        }
                        break;
                    case ">=":
                        if (list[i] < num)
                        {
                            list.Remove(list[i]);
                            i--;
                        }
                        break;
                    case "<=":
                        if (list[i] > num)
                        {
                            list.Remove(list[i]);
                            i--;
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
