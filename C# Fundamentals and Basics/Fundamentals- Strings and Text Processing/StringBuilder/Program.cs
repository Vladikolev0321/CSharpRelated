using System;
using System.Text;

namespace StringBuilder_try
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(1000);
            for (int i = 0; i < 10 ; i++)
            {
                sb.Append("Softuni");
            }
            sb.Clear(); 
            Console.WriteLine(sb);
        }
    }
}
