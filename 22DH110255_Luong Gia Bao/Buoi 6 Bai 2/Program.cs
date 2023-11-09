using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(1,2);
            Fraction f2 = new Fraction(2,3);
            Console.WriteLine(f1.ToString());
            Console.WriteLine(f2.ToString());
            Console.WriteLine(f1.Add(f2));
            Console.WriteLine(f2.Sub(f1));
            Console.WriteLine(f1.Mul(f2));
            Console.WriteLine(f2.Div(f1));
            Console.ReadKey();
        }
    }
}