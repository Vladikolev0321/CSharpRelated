using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Softuni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "course start")
                {
                    break;
                }
                string[] command = input.Split(":");
                
                string lessonTitle = command[1];
                switch (command[0])
                {
                    
                    case "Add":
                        //string lessonTitle = command[1];
                        if (!list.Contains(lessonTitle))
                        {
                            list.Add(lessonTitle);
                        }
                        break;
                    case "Insert":
                       // string lessonTitle2 = command[1];
                        int index = int.Parse(command[2]);
                        if (!list.Contains(lessonTitle))
                        {
                            list.Insert(index, lessonTitle);
                        }
                        break;
                    case "Remove":
                        if (list.Contains(lessonTitle))
                        {
                            list.Remove(lessonTitle);
                            if (list.Contains($"{lessonTitle}-Exercise"))
                            {
                                list.Remove($"{lessonTitle}-Exercise");
                            }
                        }
                        break;
                    case "Swap":
                         string lessonTitle2 = command[2];
                        if(list.Contains(lessonTitle) && list.Contains(lessonTitle2))
                        {
                            
                            string temp = command[1];
                            command[1] = command[2];
                            command[2] = temp;
                            int i1 = list.IndexOf(command[1]);
                            int i2 = list.IndexOf(command[2]);
                            list[i1] = command[2];
                            list[i2] = command[1];
                            if (list.Contains($"{command[1]}-Exercise"))
                            {
                                int ind = list.IndexOf(command[1]);
                                list.Remove($"{command[1]}-Exercise");
                                list.Insert(ind+1, $"{command[1]}-Exercise");
                            }
                            if (list.Contains($"{command[2]}-Exercise"))
                            {
                                int ind2 = list.IndexOf(command[2]);
                                list.Remove($"{command[2]}-Exercise");
                                list.Insert(ind2 + 1, $"{command[2]}-Exercise");
                            }
                        }
                        break;
                    case "Exercise":
                        if(list.Contains(lessonTitle) && !list.Contains($"{lessonTitle}-Exercise"))
                        {
                            int i = list.IndexOf(lessonTitle);
                            list.Insert(i+1, $"{lessonTitle}-Exercise");
                        }
                        if (!list.Contains(lessonTitle))
                        {
                            list.Add(lessonTitle);
                            list.Add($"{lessonTitle}-Exercise");
                        }
                        break;

                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{list[i]}");
            }
        }
    }
}
