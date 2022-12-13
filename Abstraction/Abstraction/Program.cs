using System;

namespace Abstraction
{ 
     public abstract class Shape
{
    public abstract void draw();
}

public class Square : Shape
{
    public override void draw()
    {
        Console.WriteLine("Square");
    }
}
public class Triangle : Shape
{
    public override void draw()
    {
        Console.WriteLine("Triangle");
    }
}

   public class program
    {
        public static void Main(string[] args)
        {
            //A parent class refrence variable can point to a drived class object.
            Shape shape = new Square();
            shape.draw();
            Shape shap = new Triangle();
            shap.draw();
        }
    }
}

