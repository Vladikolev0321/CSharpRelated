using System;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int sumVolews = 0;
            for(int i=0; i < text.Length; i++)
            {
                char letter = text[i];
                switch(letter)
                {
                    case 'a':
                        sumVolews = sumVolews + 1;
                        break;
                    case 'e':
                        sumVolews = sumVolews + 2;
                        break;
                    case 'i':
                        sumVolews = sumVolews + 3;
                        break;
                    case 'o':
                        sumVolews = sumVolews + 4;
                        break;
                    case 'u':
                        sumVolews = sumVolews + 5;
                        break;

                }
            }
            Console.WriteLine(sumVolews);
        }
    }
}
