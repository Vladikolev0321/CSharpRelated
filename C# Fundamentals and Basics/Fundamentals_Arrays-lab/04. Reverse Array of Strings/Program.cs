using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine().Split().ToArray();
            int length = items.Length;
            for (int i = 0; i <= length/2; i++,length--)
            {
                var old_el = items[i];
                items[i] = items[length - 1];
                items[length - 1] = old_el;
            }
            Console.WriteLine(string.Join(" ", items));
        }
    }
}
