using System;

namespace Inheritance
{

    public class Employee
    {
        public double salary = 50000;
    }
    public class Programmmer : Employee
    {
        public double bonus = 1000;
    }
     public class Program
    {
        public static void Main(string[] args)
        {
            Programmmer programmmer = new Programmmer();
            Console.WriteLine(programmmer.salary + " " + programmmer.bonus);
        }
    }
}
