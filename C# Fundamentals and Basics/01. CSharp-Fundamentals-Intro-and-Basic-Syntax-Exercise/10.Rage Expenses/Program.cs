using System;

namespace _10.Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());

            float expenses = 0;
            int countTrashedKeyboard = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if(i % 2 == 0)
                {
                    expenses += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    expenses += mousePrice;
                }
                if(i % 2 == 0 && i % 3 == 0)
                {
                    expenses += keyboardPrice;
                    countTrashedKeyboard++;
                }
                if(countTrashedKeyboard == 2)
                {
                    expenses += displayPrice;
                    countTrashedKeyboard = 0;
                }
            }

            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}
