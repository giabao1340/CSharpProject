using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Fraction
    {
        //Attribute
        protected int numerator;
        protected int denominator;
        //Properties
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }
        //Constructor
        public Fraction()
        {
            numerator = 0;
            denominator = 1;
        }
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public Fraction(int numerator)
        {
            this.numerator = numerator;
            denominator = 1;
        }
        //Method
        private static int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }
        public void simplify()
        {
            int ucln = GCD(numerator, denominator);
            numerator   = numerator / ucln;
            denominator = denominator / ucln;
        }
        private void Negative()
        {
            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
        }
        public void Input()
        {
            Console.Write("Enter numerator: ");
            Numerator = int.Parse(Console.ReadLine());
            Console.Write("Enter denominator: ");
            Denominator = int.Parse(Console.ReadLine());
            if (denominator == 0)
            {
                do
                {
                    Console.WriteLine("Denominator can not be zero, Please try again:");
                    denominator = int.Parse(Console.ReadLine());
                } while (denominator == 0);
            }
        }
        public double Decinmal() 
        {
            double dec = 1.0* Numerator/Denominator;
            return dec;
        }
        public Fraction Add(Fraction p)
        {
            int newNum = Numerator *p.Denominator + p.Numerator * Denominator;
            int newDen = Denominator * p.Denominator;
            return new Fraction(newNum, newDen);

        }
        public Fraction Sub(Fraction p)
        {
            int newNum = Numerator * p.Denominator - p.Numerator * Denominator;
            int newDen = Denominator * p.Denominator;
            return new Fraction(newNum, newDen);
        }
        public Fraction Mul(Fraction p)
        {
            int newNum = Numerator *  p.Numerator;
            int newDen = Denominator * p.Denominator;
            return new Fraction(newNum, newDen);

        }
        public Fraction Div(Fraction p)
        {
            int newNum = Numerator * p.Denominator;
            int newDen = Denominator * p.Numerator ;
            return new Fraction(newNum, newDen);
        }
        public override string ToString()
        {
            simplify();
            Negative();
            if (denominator != 1)
            {
                return $"{Numerator}/{Denominator}";
            }
            return $"{Numerator}";
        }
        public static Fraction operator + (Fraction a, Fraction b)
        {
            return a.Add(b) ;
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return a.Mul(b) ;
        }
        public static Fraction operator * (Fraction a, Fraction b)
        {
            return a.Mul(b) ;
        }
        public static Fraction operator / (Fraction a, Fraction b)
        {
            return a.Div(b) ;
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            int num_f1 = a.numerator * b.denominator;
            int numf_2 = a.denominator * b.numerator;
            return num_f1 == numf_2;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }
        public static bool operator > (Fraction a, Fraction b)
        {
            int num_f1 = a.numerator * b.denominator;
            int numf_2 = a.denominator * b.numerator;
            return num_f1 > numf_2;
        }
        public static bool operator <= (Fraction a, Fraction b)
        {
            return !(a > b);
        }
        public static bool operator >= (Fraction a, Fraction b)
        {
            return (a > b)||(a == b);
        }
        public static bool operator < (Fraction a, Fraction b)
        {
            return !(a >= b);
        }
    }
}