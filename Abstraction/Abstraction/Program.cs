using System;

namespace Abstraction
{
    abstract class Animal
    {
        
        public abstract void animalSound();
        
        public void sleep()
        {
            Console.WriteLine(" while sleeping -- Zzz");
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
