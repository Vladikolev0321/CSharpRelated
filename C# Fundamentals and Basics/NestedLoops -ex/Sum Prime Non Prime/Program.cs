using System;

namespace Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
           string command = Console.ReadLine();

            int primeSum = 0;
            int nonprimeSum = 0;
            bool is_non_prime = false;
           while(command!="stop")
            {
                int number = int.Parse(command);
                if(number<0)
                {
                    Console.WriteLine("Number is negative.");
                    command = Console.ReadLine();
                    continue;
                }
                for(int i=2;i<number;i++)
                {
                    if(number%i==0)
                    {
                        is_non_prime = true;
                        break;
                    }
                }
                if(is_non_prime && number!= 1)
                {
                     nonprimeSum += number;
                    is_non_prime = false;
                }
                else
                {
                   primeSum += number; 
                }


                 
                command = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonprimeSum}");
        }
    }
}
