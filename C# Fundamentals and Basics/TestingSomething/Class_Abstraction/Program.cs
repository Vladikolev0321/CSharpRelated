using System;

namespace Class_Abstraction
{
   
    ///abstract///keyword for methods and classes //abstract class - restricted class(to use it must be in inherited from
    //another class) // abstract method - can be used only in abstract class and dont have a body ;the body is provided
    // by the derived class 
   
     

    abstract class Animal
    {
        public abstract void animalSound();

        public void sleep()
        {
            Console.WriteLine("zzzz");
        }

    }
    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says wee wee");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();
            myPig.animalSound();
            myPig.sleep();  
        }
    }
}
