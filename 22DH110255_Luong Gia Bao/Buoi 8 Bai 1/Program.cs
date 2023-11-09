using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Caculator.Add(3.14, 12.1));
            Console.WriteLine(Caculator.Subtract(2.5, 1.8));
            Console.WriteLine(Caculator.Multiply(3, 2));
            Console.WriteLine(Caculator.Divide(3.14, 12.1));
            Console.WriteLine(Caculator.Max(3.14, 12.1));
            Console.WriteLine(Caculator.Min(3.14, 12.1));


            Console.ReadKey();


        }
    }
}
