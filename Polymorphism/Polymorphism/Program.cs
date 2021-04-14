using System;

namespace Polymorphism
{
    class Animal  
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
            Console.ReadLine();
        }
    }

    class Pig : Animal  
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
            Console.ReadLine();
        }
    }

    class Dog : Animal  
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
            Console.ReadLine();
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
