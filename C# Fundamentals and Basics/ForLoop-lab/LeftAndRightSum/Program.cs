using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftsum = 0;
            int rightsum = 0;
            for(int i=0;i<n*2;i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(i<n)
                {
                    leftsum += num;
                }
                else if(i<n*2)
                {
                    rightsum += num;
                }
            }
            
            if(rightsum == leftsum)
            {
                Console.WriteLine($"Yes, sum = {rightsum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(rightsum-leftsum)}");

            }

        }
    }
}
