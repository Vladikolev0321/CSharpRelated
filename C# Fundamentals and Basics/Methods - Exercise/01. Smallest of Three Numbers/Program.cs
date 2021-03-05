using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Min(n1, n2, n3));

        }
        static int Min(int n1 , int n2 , int n3)
        {
          //  int min = int.MaxValue;
            if(n1 < n2 && n1 < n3)
            {
                return n1;
            }
            else if(n2 < n1 && n2 < n3)
            {
                return n2;
            }
            else
            {
                return n3;
            }
        }
    }
}
