using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            bool foundComb = false;

            int combCounter = 0;
            for(int i = first;i<=last;i++)
            {
                for(int j=first;j<=last;j++)
                {
                    combCounter++;
                    if((i+j)==magicNum)
                    {
                        Console.WriteLine($"Combination N:{combCounter} ({i} + {j} = {magicNum})");
                        foundComb = true;
                        break;
                    }
                }
                if(foundComb)
                {
                    break;
                }
            }
            if(!foundComb)
            {
                Console.WriteLine($"{ combCounter} combinations - neither equals { magicNum}");
            }
        }
    }
}
