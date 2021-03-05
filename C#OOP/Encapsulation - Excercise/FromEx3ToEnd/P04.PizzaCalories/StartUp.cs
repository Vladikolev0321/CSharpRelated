using P04.PizzaCalories.Ingredients;
using System;

namespace P04.PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] inputName = Console.ReadLine().Split();
                string pizzaName = inputName[1];

                string[] inputDough = Console.ReadLine().Split();
                string flourType = inputDough[1];
                string bakingTech = inputDough[2];
                double weight = double.Parse(inputDough[3]);

                Dough dough = new Dough(flourType, bakingTech, weight);

                ////Creating pizza

                Pizza pizza = new Pizza(pizzaName, dough);

                string command;
                while((command=Console.ReadLine()) != "END")
                {
                    string[] commandArgs = command
                    .Split();
      
                     string toppingType = commandArgs[1];
                     double weight1 = double.Parse(commandArgs[2]);

                     Topping topping = new Topping(toppingType, weight1);

                    pizza.AddTopping(topping);

                      //  Console.WriteLine($"{topping.ToppingCalories():F2}");
                }
                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:F2} Calories.");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }
    }
}
