using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstNum = Console.ReadLine()
                .ToCharArray();
            int multiplier = int.Parse(Console.ReadLine());
            if(multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder sb = new StringBuilder(); 
            int remainder = 0;

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                char currentCh = firstNum[i];
                int currNum = int.Parse(currentCh.ToString());

                int sum = (currNum * multiplier) + remainder;
                sb.Append(sum % 10);
                remainder = sum / 10;
                

            }
            if(remainder != 0)
            {
            sb.Append(remainder);
            }

            List<char> result = sb.ToString().Reverse()
                .ToList();


            RemoveTrailingZeros(result);

            Console.WriteLine(string.Join("", result));
        }
        private static void RemoveTrailingZeros(List<char> resultArr)
        {
           
                if(resultArr[0] == '0')
                {
                    int endIndex = 0;

                    for (int j = 1; j < resultArr.Count; j++)
                    {
                        if(resultArr[j] != '0')
                         {
                            endIndex = j;
                         }   
                    }

                for (int i = 0; i < endIndex; i++)
                {
                    resultArr.RemoveAt(0);
                }
                }

                
            
        }
    }
}
