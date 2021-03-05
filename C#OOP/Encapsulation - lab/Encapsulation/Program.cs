using System;
using System.Runtime.CompilerServices;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // var cat = new Cat("Luchko",3,"Ivan");

            // Console.WriteLine(cat.Details());


            ///////////////
            //var person = new PersonBuilder()
            //    .WithFirstName("Ivan")
            //    .WithAge(15)
            //    .Build();


            //var person = new Person();

            //person
            //    .RegisterForExam()
            //    .ParticipateInExam()
            //    .CalculateScore(); 

            //var name  = SetValue("Ivan")

            //}
            //private static void SetValue(string name)
            //{
            //   // name ??= throw new InvalidOperationException();
            //}

            var team = new Team("Top Team");

            team.AddPlayer(new Person("Ivan", "Ivanov", 50));
            team.AddPlayer(new Person("Ivan", "Peshov", 30));

            Console.WriteLine(team.FirstTeam.Count);
            Console.WriteLine(team.ReserveTeam.Count);

        }

    }
}
