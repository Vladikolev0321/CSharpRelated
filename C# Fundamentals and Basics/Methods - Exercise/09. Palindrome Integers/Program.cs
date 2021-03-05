using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine();
                if(command == "END")
                {
                    break;
                }
                int num = int.Parse(command);
                IsPalindrome(num);

            }
        }
        static void IsPalindrome(int n)
        {
            string str = n.ToString();
            string res = "";
            int len = str.Length - 1;
            while(len >= 0)
            {
                res += str[len];
                len--;
            }
            if(str == res)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
