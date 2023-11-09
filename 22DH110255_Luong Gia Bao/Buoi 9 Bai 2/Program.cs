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
            Console.WriteLine(Fraction.Add(a, b));
            Console.WriteLine(Fraction.Sub(a, b));
            Console.WriteLine(Fraction.Mul(a, b));
            Console.WriteLine(Fraction.Div(a, b));

            MixedFraction mf1 = new MixedFraction(1, 2, 3);
            MixedFraction mf2 = new MixedFraction(1, 2, 3);
            Console.WriteLine(Fraction.Add(mf1, mf2));
            Console.WriteLine(Fraction.Sub(mf1, mf2));
            Console.WriteLine(Fraction.Mul(mf1, mf2));
            Console.WriteLine(Fraction.Div(mf1, mf2));



            Console.ReadKey();
        }
    }
}