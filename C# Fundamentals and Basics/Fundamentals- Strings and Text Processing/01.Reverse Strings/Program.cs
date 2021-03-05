using System;
using System.Linq;

namespace _01.Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            while(str != "end")
            {
                string reversed = "";
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    reversed += str[i];
                }
                Console.WriteLine($"{str} = {reversed}");

                str = Console.ReadLine();
            }
        }
    }
}
