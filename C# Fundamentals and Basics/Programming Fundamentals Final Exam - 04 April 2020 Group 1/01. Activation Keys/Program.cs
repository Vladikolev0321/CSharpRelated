using System;
using System.Text;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "Generate")
                {
                    break;
                }
                string[] command = input.Split(">>>");

                if(command[0] == "Contains")
                {
                    string sub = command[1];
                    if (key.Contains(sub))
                    {
                        Console.WriteLine($"{key} contains {sub}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if(command[0] == "Flip")
                {
                    int startIndex = int.Parse(command[2]);
                    int endIndex = int.Parse(command[3]);
                    if (command[1] == "Upper")
                    {
                        //string sub = key.Substring(startIndex, endIndex)
                       // //key = sub.ToUpper();
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < key.Length; i++)
                        {
                            //key[i] = key[i].ToString().ToUpper();
                            if (i >= startIndex && i < endIndex)
                            {
                                sb.Append(key[i].ToString().ToUpper());
                            }
                            else
                            {
                                sb.Append(key[i]);
                            }
                                                     
                        }
                        key = sb.ToString();
                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < key.Length; i++)
                        {
                            //key[i] = key[i].ToString().ToUpper();
                            if (i >= startIndex && i < endIndex)
                            {
                                sb.Append(key[i].ToString().ToLower());
                            }
                            else
                            {
                                sb.Append(key[i]);
                            }

                        }
                        key = sb.ToString();
                    }
                    Console.WriteLine(key);
                }
                else
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    int count = endIndex - startIndex;
                    key = key.Remove(startIndex, count);
                    Console.WriteLine(key);
                }

            }
            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
