using System;

namespace EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string set = Console.ReadLine();
            int countSet = int.Parse(Console.ReadLine());

            double res = 0; ;

            switch(fruit)
            {
                case "Watermelon":
                    if(set=="small")
                    {
                        res = countSet * 2 * 56;
                    }
                    else
                    {
                        res = countSet * 5 * 28.70;
                    }
                    break;
                case "Mango":
                    if (set == "small")
                    {
                        res = countSet * 2 * 36.66;
                    }
                    else
                    {
                        res = countSet * 5 * 19.60;
                    }
                    break;
                case "Pineapple":
                    if (set == "small")
                    {
                        res = countSet * 2 * 42.10;
                    }
                    else
                    {
                        res = countSet * 5 * 24.80;
                    }
                    break;
                case "Raspberry":
                    if (set == "small")
                    {
                        res = countSet * 2 * 20;
                    }
                    else
                    {
                        res = countSet * 5 * 15.20;
                    }
                    break;
            }
            if(res >=400 && res<=1000)
            {
                res = res - res * 0.15;
            }
            else if(res>1000)
            {
                res = res - res * 0.5;
            }
            Console.WriteLine($"{res:F2} lv.");
            

           
        }
    }
}
