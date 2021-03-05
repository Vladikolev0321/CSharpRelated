using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inpArgs = Console.ReadLine()
                .Split()
                .ToArray();

            Console.WriteLine(CharMultiplier(inpArgs[0], inpArgs[1]));

        }
        public static int CharMultiplier(string f, string s)
        {
            int sum = 0;
            int shorterLen = 0;

            if(f.Length != s.Length)
            {
             shorterLen = f.Length > s.Length ? s.Length : f.Length;

            }
            else
            {
                shorterLen = f.Length;
            }

            for (int i = 0; i < shorterLen; i++)
            {
                sum += (int)(s[i] * f[i]);
            }

            if(shorterLen == f.Length && shorterLen < s.Length)
            {
                for (int i = f.Length; i < s.Length; i++)
                {
                    sum += (int)(s[i]);
                }
            }
            else if(shorterLen == s.Length && shorterLen < f.Length)
            {
                for (int i = s.Length; i < f.Length; i++)
                {
                    sum += (int)(f[i]);
                }
            }
            return sum;
        }
    }
    
}
