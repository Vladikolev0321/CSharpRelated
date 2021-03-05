using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string oper = Console.ReadLine();

            double result = 0.0 ;
            switch(oper)
            {
                case "+":
                    result = n1 + n2;
                    string isOdd = "";
                    if(result % 2 == 0)
                    {
                        isOdd = "even";
                    }
                    else
                    {
                        isOdd = "odd";
                    }
                    Console.WriteLine($"{n1} {oper} {n2} = {result} - {isOdd}");


                    break;
                case "-":
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        isOdd = "even";
                    }
                    else
                    {
                        isOdd = "odd";
                    }



                    Console.WriteLine($"{n1} {oper} {n2} = {result} - {isOdd}");

                    break;
                case "*":
                    result = n1 * n2;

                    if (result % 2 == 0)
                    {
                        isOdd = "even";
                    }
                    else
                    {
                        isOdd = "odd";
                    }
                    Console.WriteLine($"{n1} {oper} {n2} = {result} - {isOdd}");

                    break;
                case "/":
                    
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else 
                    {   
                        result = (double)n1 / (double)n2;
                        Console.WriteLine($"{n1} {oper} {n2} = {result:F2}");
                    } 
                    break;
                case "%":
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        result = n1 % n2;
                        Console.WriteLine($"{n1} {oper} {n2} = {result}");

                        
                    }
                    break;



            }

        }
    }
}
