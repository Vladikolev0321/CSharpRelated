using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int res = Sum(num1, num2);
            Console.WriteLine(Subtract(res, num3));


        }
        static int Sum(int n1,int n2)
        {
            return n1 + n2;
        }
        static int Subtract(int n1 , int n2)
        {
            return n1 - n2;
        }
    }
}
