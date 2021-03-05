using System;
using System.Collections.Generic;

namespace Try
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLongestSubstring("aab"));
        }

        public static int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> countChar = new Dictionary<char, int>();
            int counter = 0;
            int maxCounter = 0;
            foreach (char c in s)
            {
                counter++;
                if (countChar.ContainsKey(c))
                {
                    countChar[c]++;
                    countChar = null;
                    countChar = new Dictionary<char, int>();
                    
                    counter = 0;
                    //continue;
                }
                else
                {
                    countChar[c] = 0;
                }
                if (maxCounter < counter)
                {
                    maxCounter = counter;
                }
            }
            return maxCounter;
        }
    }
}
