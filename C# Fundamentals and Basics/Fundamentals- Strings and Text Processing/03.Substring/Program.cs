using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string sub = Console.ReadLine().ToLower();
            string text = Console.ReadLine();

            ////if it doesn't contain it returns -1
            while (text.Contains(sub))  
            {
                int startIndex = text.IndexOf(sub);
                 text = text.Remove(startIndex, sub.Length);
                //string firstHalf = text.Substring(0, startIndex);
                //string secondHalf = text.Substring(startIndex + sub.Length);
            }
            Console.WriteLine(text);
        }
    }
}
