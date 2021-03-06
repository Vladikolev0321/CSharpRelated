using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();


            Stack<int> materialsForCrafting = new Stack<int>(input1);
            Queue<int> magicLevelValues = new Queue<int>(input2);


            Dictionary<int, string> presentsMagicLevel = new Dictionary<int, string>
            {
                { 150,"Doll" },
                { 250,"Wooden train"},
                { 300,"Teddy bear" },
                { 400,"Bicycle"}
            };

            SortedDictionary<string, int> presentsMade = new SortedDictionary<string, int>();
                //DOll ->1
                //Bicycle ->2

            while(materialsForCrafting.Count > 0 && magicLevelValues.Count>0)
            {
                int magicLevel = materialsForCrafting.Peek() * magicLevelValues.Peek();
                
                if(presentsMagicLevel.ContainsKey(magicLevel))
                {
                    if (!presentsMade.ContainsKey(presentsMagicLevel[magicLevel]))
                    {
                        presentsMade.Add(presentsMagicLevel[magicLevel], 0);
                    }
                    presentsMade[presentsMagicLevel[magicLevel]]++;

                    materialsForCrafting.Pop();
                    magicLevelValues.Dequeue();
                }
                
                else
                {

                    if(magicLevel<0)
                    {
                        int sum = materialsForCrafting.Peek() + magicLevelValues.Peek();
                        materialsForCrafting.Pop();
                        magicLevelValues.Dequeue();
                        materialsForCrafting.Push(sum);
                    }
                    else if(magicLevel>0)
                    {
                        int material = materialsForCrafting.Peek() + 15;
                        materialsForCrafting.Pop();
                        magicLevelValues.Dequeue();
                        materialsForCrafting.Push(material);
                    }
                    else if(magicLevel==0)
                    {
                        if (materialsForCrafting.Peek() == 0)
                        {
                            materialsForCrafting.Pop();
                        }
                        if(magicLevelValues.Peek()==0)
                        {
                            magicLevelValues.Dequeue();
                        }
                    }
                }
            }

            if((presentsMade.ContainsKey("Doll") && presentsMade.ContainsKey("Wooden train"))
               || (presentsMade.ContainsKey("Teddy bear")&& presentsMade.ContainsKey("Bicycle")))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            if(materialsForCrafting.Count>0)
            {
                Console.WriteLine("Materials left:"+ string.Join(", ",materialsForCrafting));
            }
            if(magicLevelValues.Count>0)
            {
                Console.WriteLine("Magic left:" + string.Join(", ", magicLevelValues));
            }

            foreach (var present in presentsMade)
            {
                Console.WriteLine($"{present.Key}: {present.Value}");
            }


        //    10 - 5 20 15 -30 10
         //   40 60 10 4 10 0
       //          10 - 5 20 15 - 30 10
        //    40 60 10 4 10 0
        }
    }
}
