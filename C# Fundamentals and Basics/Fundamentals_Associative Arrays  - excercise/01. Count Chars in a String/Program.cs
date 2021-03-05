using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char currCh = text[i];
                if(currCh == ' ')
                {
                    continue;
                }
                if (!dict.ContainsKey(currCh))
                {
                    dict[currCh] = 1;
                }
                else
                {
                    dict[currCh]++;
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }




            //for (int i = 0; i < word.Length; i++)
            //{
            //    char symbol = char.Parse(word[i]);
            //    Console.WriteLine(symbol);
               
            //}


        }
    }
}
