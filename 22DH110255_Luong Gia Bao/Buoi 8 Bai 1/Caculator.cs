using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    internal class Caculator
    {
        //Constructor
        public Caculator() { }

        //Methods
        public static int Add(int a, int b){   return a + b; }//non-static
        public static double Add(double a, double b) {  return a + b; }//static
        public static int Subtract(int a, int b) { return a - b; }
        public static double Subtract(double a, double b) { return a - b; }
        public static int Multiply(int a, int b) { return a * b; }
        public static double Multiply(double a, double b) { return a * b; }
        public static int Divide(int a, int b) { return a / b; }
        public static double Divide(double a, double b) { return a / b; }
        public static int Min(int a, int b) { return a > b ? b : a; }
        public static double Min(double a, double b) { return a > b ? b : a; }
        public static int Max(int a, int b) { return a < b ? b : a; }
        public static double Max(double a, double b) { return a < b ? b : a; }
    }

}
