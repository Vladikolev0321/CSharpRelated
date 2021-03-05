using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //double a= 23.34343543;
            //Console.WriteLine(Math.Round(a, 2));
            double ivanchoMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double priceSabre = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());

            double countSabres = studentsCount + studentsCount * 0.1;
            countSabres = Math.Ceiling(countSabres);
          //  Console.WriteLine($"Count sabres:{countSabres}");
            
            int freeBelts = studentsCount / 6;



            double countBelts = studentsCount - freeBelts;

       // Console.WriteLine($"Count belts:{countBelts}");
           // Console.WriteLine($"Count :{freeBelts}");

            double res = (countSabres * priceSabre) + (countBelts * priceBelt) + (studentsCount * priceRobe);

           // Console.WriteLine($"Resultat:{res}");


            if (res <= ivanchoMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {res:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {res - ivanchoMoney:F2}lv more.");
            }
      //      Console.WriteLine(freeBelts);





        }
    }
}
