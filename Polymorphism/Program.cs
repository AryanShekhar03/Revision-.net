using System;

namespace Polymorphism
{

    public class Human
    {
        public virtual void eat()
        {
            Console.WriteLine("Human eating");
        }
    }
    public class Dog : Human
    {
        public override void eat()
        {
            Console.WriteLine("Dog eating");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Human h = new Dog();
            h.eat();
        }
    }
}
