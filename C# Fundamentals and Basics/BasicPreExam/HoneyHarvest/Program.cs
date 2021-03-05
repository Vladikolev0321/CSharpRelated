using System;

namespace HoneyHarvest
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlower = Console.ReadLine();
            int countFlowers = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double result=0;

            if(season == "Spring")
            {
                switch (typeFlower)
                {
                    case "Sunflower":
                        result = countFlowers * 10;
                        break;
                    case "Daisy":
                        result = countFlowers * (12+12*0.1);
                        break;
                    case "Lavender":
                        result = countFlowers * 12;
                        break;
                    case "Mint":
                        result = countFlowers * (10+10*0.1);
                        break;
                }
              //  result += result * 0.1;

            }
            
            if(season == "Summer")
            {
                switch (typeFlower)
                {
                    case "Sunflower":                        
                    case "Daisy":                       
                    case "Lavender":
                        result = countFlowers * 8;
                        break;
                    case "Mint":
                        result = countFlowers * 12;
                        break;
                }
                result += result * 0.1;
            }
            
            if(season == "Autumn")
            {
              //  Console.WriteLine("AAAAA");
                switch (typeFlower)
                { //Console.WriteLine("AAAAA");
                    case "Sunflower":
                        result = countFlowers * 12;
                        //Console.WriteLine(result);
                        break;
                    case "Daisy":
                        result = countFlowers * 6;
                        break;
                    case "Lavender":
                        result = countFlowers * 6;
                        break;
                    case "Mint":
                        result = countFlowers * 6;
                        break;
                }
                result = result *0.95;
            }

            Console.WriteLine($"Total honey harvested: {result:F2}");

        }
    }
}
