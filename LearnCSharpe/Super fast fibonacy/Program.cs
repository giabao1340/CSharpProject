using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_fast_fibonacy
{
    internal class Program
    {
        static long Super_fast_fibonacy(int n)
        {
            if (n == 1 || n == 2 )
            {
                return 1;
            }
            long a = 1, b = 1;
            for (long i = 3; i <= n; i++)
            {
                b = a + b;
                a = b-a;
            }
            return b;
        }
        static long fib(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return fib(n - 2) + fib(n - 1);
        }
        static void nFib(int n)
        {
            int dem = 1;
            int i = 1;
            while (dem <= n)
            {
                Console.WriteLine(Super_fast_fibonacy(i));
                i++;
                dem++;
            }
        }
        static  void m(int n)
        {
            Console.WriteLine( n%10);
            if (n != 0)
            {
                    m(n / 10);
            }
            Console.WriteLine(n%10);
        }
        static void Main(string[] args)
        {


            m(1234);
        }
    }
}
