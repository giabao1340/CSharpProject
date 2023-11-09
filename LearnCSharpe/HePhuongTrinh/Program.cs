using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HePhuongTrinh
{
    internal class Program
    {        
        public static void HePT (double a, double b, double c, double d, double r, double s,out  double x, out double y)
        {
            //y = PTB1(a * d - b * c, c * r, a * s);
            y = (a * s - c * r) / (a * d - b * c);
            x = (r - b*y) / a;

        }

        static void Main(string[] args)
        {
            double a, b, c, d, r, s, x, y;

            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("r = ");
            r = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());
            Console.Write("d = ");
            d = double.Parse(Console.ReadLine());
            Console.Write("s = ");
            s = double.Parse(Console.ReadLine());
            HePT(a, b, c, d, r, s, out x, out y);
            Console.WriteLine( "x = " + x);
            Console.WriteLine("y = "+ y);
        }
    }
}
