using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;

            for(int i =0; i<n;i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum = sum + num; 
                if(max < num)
                {
                    max = num;
                }
            }
            int sumWithoutMax = sum - max;
            if(max == sumWithoutMax)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
            }
            else
            {
                int diff = Math.Abs(max - sumWithoutMax);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
