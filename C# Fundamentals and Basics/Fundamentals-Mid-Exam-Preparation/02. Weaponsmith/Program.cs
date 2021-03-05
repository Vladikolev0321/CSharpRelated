using System;
using System.Collections.Generic;

namespace _02._Weaponsmith
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split("|");
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "Done")
                {
                    break;
                }
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Move":
                        int index = int.Parse(command[2]);
                        if (command[1] == "Left")
                        {
                            if (index > 0 && index - 1 >= 0 && index<arr.Length)
                            {
                                string temp = arr[index];
                                arr[index] = arr[index - 1];
                                arr[index - 1] = temp;
                            }
                        }
                        else
                        {
                            if (index >= 0 && index + 1 < arr.Length )
                            {
                                string temp = arr[index];
                                arr[index] = arr[index + 1];
                                arr[index + 1] = temp;
                            }
                        }
                        break;
                    case "Check":
                        if (command[1] == "Even")
                        {
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (i % 2 == 0)
                                {
                                    Console.Write($"{arr[i]} ");
                                }
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (i % 2 != 0)
                                {
                                    Console.Write($"{arr[i]} ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                }
            }
            string wearponName = "";
            foreach (string item in arr)
            {
                wearponName += item;
            }
            /// stringJoin can also be used

            Console.Write($"You crafted {wearponName}!");
        }
    }
}
