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
            Fraction a = new Fraction(1, -2);
            Fraction b = new Fraction(3, 4);
            Console.WriteLine(a.Add(b));
            Console.WriteLine(a.Sub(b));
            Console.WriteLine(a.Mul(b));
            Console.WriteLine(a.Div(b));



            MixedFraction mf1 = new MixedFraction(1, 2, 3);
            MixedFraction mf2 = new MixedFraction(1, 2, 3);
            Console.WriteLine(mf1.Add(mf2));
            Console.WriteLine(mf1.Sub(mf2));
            Console.WriteLine(mf1.Mul(mf2));
            Console.WriteLine(mf1.Div(mf2));

            Console.ReadKey();
        }
    }
}