using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] field = new int[size];
            //  field = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] IndexesWithBees = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < IndexesWithBees.Length; i++)
            {
                if (IndexesWithBees[i] < field.Length&& IndexesWithBees[i] >= 0)
                {
                    field[IndexesWithBees[i]] = 1;
                }
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string[] command = input.Split();
                int ladybugIndex = int.Parse(command[0]);
                string direction = command[1];
                int flyLength = int.Parse(command[2]);
                //  Console.WriteLine(ladybugIndex + direction + flyLength);
                if (field[ladybugIndex] == 1 && ladybugIndex < field.Length && ladybugIndex >= 0
                    && flyLength != 0)
                {
                    field[ladybugIndex] = 0;
                    if (direction == "right")
                    {
                        if ((ladybugIndex + flyLength) < size
                             && ladybugIndex + flyLength >= 0
                            && field[ladybugIndex + flyLength] == 0)
                        {
                            //if (field[ladybugIndex + flyLength] != 1)
                            //{
                            field[ladybugIndex + flyLength] = 1;
                            //}
                        }
                        /////////Problemno
                        else if (ladybugIndex + flyLength < field.Length
                             && ladybugIndex + flyLength >= 0 &&
                            field[ladybugIndex + flyLength] == 1)
                             {
                            //if ((ladybugIndex + flyLength + ladybugIndex+ flyLength) < size)
                            //{
                            ///    field[ladybugIndex + flyLength + ladybugIndex + flyLength] = 1;
                            //}
                            while (ladybugIndex + flyLength < field.Length
                              && ladybugIndex + flyLength >= 0
                              && field[ladybugIndex + flyLength] == 1) //продължава напред със същия брой движения ДОКАТО не открие празно място
                            {
                                flyLength += flyLength; //затова увеличаваме хода със същия брой движения
                                if (ladybugIndex + flyLength < field.Length
                                    && ladybugIndex + flyLength >= 0 // а тази проверка е в случай, че числото е ОТРИЦАТЕЛНО, за да не излезе от полето НАЛЯВО
                                    && field[ladybugIndex + flyLength] == 0)
                                {
                                    field[ladybugIndex + flyLength] = 1; //ако открие празна позиция, я заема
                                    break; //и излизаме от while-цикъла
                                }
                            }

                            }
                    }
                }
                else if (direction == "left")
                {

                    if ((ladybugIndex - flyLength) >= 0 && ladybugIndex - flyLength < field.Length 
                        && field[ladybugIndex - flyLength] == 0)
                    {
                        //if (field[ladybugIndex - flyLength] != 1)
                        //{
                        field[ladybugIndex - flyLength] = 1;
                        //}
                    }
                    /////////Problemno
                    else if (field[ladybugIndex - flyLength] == 1 && ladybugIndex - flyLength >= 0
                                 && ladybugIndex - flyLength < field.Length)
                    {
                        //    if ((ladybugIndex - flyLength - ladybugIndex - flyLength) >= 0)
                        //    {
                        //        field[ladybugIndex - flyLength - ladybugIndex - flyLength] = 1;
                        //    }
                        while (ladybugIndex - flyLength >= 0 // ДОКАТО (while) не открие празна позиция
                              && ladybugIndex - flyLength < field.Length
                              && field[ladybugIndex - flyLength] == 1)
                        {
                            flyLength += flyLength; // тук си е плюс, а не минус, въпреки че е наляво, но... за да не ходи напред-назад
                            if (ladybugIndex - flyLength >= 0
                                && ladybugIndex - flyLength < field.Length
                                && field[ladybugIndex - flyLength] == 0)
                            {
                                field[ladybugIndex - flyLength] = 1;
                                break;
                            }
                        }

                    
                    }



                }
            }
                Console.WriteLine(string.Join(" ", field));
            
        }
    }
}
