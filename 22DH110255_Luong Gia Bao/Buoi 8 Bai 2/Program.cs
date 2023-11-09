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
            MixedFraction mf1 = new MixedFraction(1, 2, 3);
            MixedFraction mf2 = new MixedFraction(1, 2, 3);
            Console.WriteLine(mf1+mf2);
            MixedFraction mf3 = mf1.Add(mf2);


            Console.WriteLine($"{a} + {b} = {a+b}");
            Console.WriteLine($"{a} - {b} = {a-b}");
            Console.WriteLine($"{a} * {b} = {a*b}");
            Console.WriteLine($"{a} / {b} = {a/b}");

            Console.WriteLine(a<b);
            Console.WriteLine(mf1 == mf2);

            Console.ReadKey();
        }
    }
}