using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = 0;
            bool isEqualSum = false;
            
            for (int i = 0; i < arr.Length; i++)
            {
                int sumRight = 0;
                int sumLeft = 0;
                for (int j = 0; j < i; j++)
                {
                    sumLeft += arr[j];
                }
                for (int k = i+1; k < arr.Length; k++)
                {
                    sumRight += arr[k];
                }
                if(sumLeft == sumRight)
                {
                    index = i;
                    isEqualSum = true;
                    break;
                }
            }
            if (isEqualSum)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
