using System;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.setFilled(true);
            circle.setColor("Red");
            //circle.setRadius(10);
            Console.WriteLine(circle.getRadius());
            Console.WriteLine(circle.ToString());

            Rectangle rectangle = new Rectangle();
            rectangle.setLength(10);
            rectangle.setWidth(5);
            rectangle.setFilled(false);
            rectangle.setColor("blue");
            Console.WriteLine(rectangle.ToString());

            Square square = new Square(5);
            square.setFilled(false);
            square.setColor("blue");
            Console.WriteLine(square.ToString());

            

            Console.ReadKey();
        }
    }
}
