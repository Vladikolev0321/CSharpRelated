using System;

namespace Methods
{
    class Program
    {
        
        /// overloading func - 2 or more functions with the same name doing the same thing with different types of parameters
        ///recoursing - to call the func in the same func
        
        static void Main(string[] args)
        {
            //int a = 4; int b = 7;
            int sum = SumNumbers(5,6);
            Console.WriteLine(sum);
        }
        
         
        static int SumNumbers(int num1 , int num2)
        {
            //Console.WriteLine("Hello!");
            return num1 + num2;
        }

        static double SumNumbers(double num1,double num2)
        {
            return num1 + num2;
        }
    }
}
