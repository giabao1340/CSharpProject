using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau2
{
    internal class Program
    {

        static int TongLuyThua(int n)
        {
            //S(n) = n^2 + (n-1)^2 + ... + 1
            int sum = 0;
            if (n == 1) { return 1; }
            sum += (int)Math.Pow(n, 2);
            return sum + TongLuyThua(n-1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"S() = " +TongLuyThua(3));
        }
    }
}
