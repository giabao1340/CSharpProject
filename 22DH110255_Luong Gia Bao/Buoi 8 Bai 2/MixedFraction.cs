using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class MixedFraction : Fraction
    {

        public MixedFraction() { }
        public MixedFraction(int wholePart, int numerator, int denominator): base(wholePart * denominator + numerator, denominator){}

        public override string ToString()
        {
            return $"{numerator/denominator}[{numerator%denominator}/{denominator}]";
        }

    }
}
