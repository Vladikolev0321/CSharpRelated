using System;

namespace Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            for(int i=first;i<=second;i++)
            {
                string currentNum = i.ToString();
                int oddSum = 0;
                int evenSum = 0;
                for(int j=0;j<currentNum.Length;j++)
                {
                    int currDigit = int.Parse(currentNum[j].ToString());
                    if(j%2==0)
                    {
                        evenSum += currDigit;
                    }
                    else
                    {
                        oddSum += currDigit;
                    }
                }
                if(oddSum == evenSum)
                {
                    Console.Write(currentNum +" ");
                }
            }
        }
    }
}
