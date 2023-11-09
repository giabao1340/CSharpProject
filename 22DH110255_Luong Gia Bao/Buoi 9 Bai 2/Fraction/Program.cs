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
            //Fraction a = new Fraction(-1, 2);
            ////a.Input();
            //Fraction b = new Fraction(3, 4);
            MixedFraction m = new MixedFraction();
            
            MixedFraction mf = new MixedFraction(1, 2, 3);
            Fraction ft = mf.Convert();
            Console.WriteLine(ft.ToString());
            //Fraction c = a + b;
            //Fraction d = a - b;
            //Fraction e = b * c;
            //Fraction f = a / d;
            //b.Input();
            //Fraction add = a.Add(b);
            //Fraction sub = a.Sub(b);
            //Fraction mul = a.Mul(b);
            //Fraction div = a.Div(b);

            //Console.WriteLine($"{a.ToString()} + {b.ToString()} = {add.ToString()}");
            //Console.WriteLine($"{a.toString()} - {b.toString()} = {sub.toString()}");
            //Console.WriteLine($"{a.toString()} * {b.toString()} = {mul.toString()}");
            //Console.WriteLine($"{a.toString()} / {b.toString()} = {div.toString()}");

            //Console.WriteLine($"{a.ToString()} + {b.ToString()} = {c.ToString()}");
            //Console.WriteLine($"{a.ToString()} - {b.ToString()} = {d.ToString()}");
            //Console.WriteLine($"{a.ToString()} * {b.ToString()} = {e.ToString()}");
            //Console.WriteLine($"{a.ToString()} / {b.ToString()} = {f.ToString()}");

            //Console.WriteLine(a < b);

            //Console.WriteLine(a.Decinmal());
            //Console.WriteLine(b.Decinmal());
            Console.ReadKey();
        }
    }
}