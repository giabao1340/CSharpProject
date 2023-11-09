using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class MixedFraction : Fraction
    {
        public int wholePart;
        
        public MixedFraction() { }
        public MixedFraction(int wholePart, int numerator, int denominator): base(numerator, denominator)
        {
            this.wholePart = wholePart;
        }
        //method
        public Fraction Convert()
        {
            int newnumerator = wholePart * numerator + this.Denominator;
            int Newdenominator = this.Denominator;
            return new Fraction(newnumerator, Newdenominator);
        }
        public override string ToString()
        {
            return $"{wholePart}[{base.ToString()}]";
        }
    }
}
