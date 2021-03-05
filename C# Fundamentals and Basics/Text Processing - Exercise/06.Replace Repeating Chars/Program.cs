using System;

namespace _06.Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char currCh = input[i];

                int subSequenceLength = 1;
                for (int j = i + 1; j < input.Length; j++)
                {
                    char nextCh = input[j];

                    if(currCh == nextCh)
                    {
                        subSequenceLength++;
                    }
                    else
                    {
                        break;
                    }
                }
                if(subSequenceLength > 1)
                {
                input = input.Remove(i + 1, subSequenceLength - 1);
                }
            }
            Console.WriteLine(input);
        }
    }
}
