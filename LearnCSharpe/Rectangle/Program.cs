using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Input();
            rectangle.Output();
            Rectangle rect = new Rectangle(2, -3);
            rect.Output();
            Console.WriteLine(rectangle.GetPerimeter());
            Console.WriteLine(rectangle.GetArea());
            Console.WriteLine(rectangle.IsSameArea(rect));
        }
    }
}