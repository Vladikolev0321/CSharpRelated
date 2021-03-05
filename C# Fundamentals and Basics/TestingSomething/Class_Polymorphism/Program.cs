using System;

namespace Class_Polymorphism
{


    /// to override base class method  use //virtual// 
    /// when you override in derived class use //override
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes sounds");
        }
    }    
    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");

        }
    }
    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The  dog says : Bark Bark");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myPig = new Pig();
            Animal myDog = new Dog();

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }
    }
}
