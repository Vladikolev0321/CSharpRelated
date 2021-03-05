using System;

namespace _08.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxVolume = double.MinValue;
            string maxModel = "";
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double currVolume = Math.PI * Math.Pow(radius,2) * height;
                if (currVolume > maxVolume)
                {
                    maxVolume = currVolume;
                    maxModel = model;
                }
            }
            Console.WriteLine(maxModel);
        }
    }
}
