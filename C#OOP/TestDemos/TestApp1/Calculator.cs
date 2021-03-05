using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp1
{
    public class Calculator
    {
        public int CalculateSum(params int[] numbers)
        {
            return numbers.Sum();
        }

        public int Product(params int[] numbers)
        {
            int result = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                result *= numbers[i];
            }

            return result;
        }
    }
}
