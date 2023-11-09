using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static int gt(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * gt(n - 1);
        }
        static int lt(int a, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return a * lt(a, n - 1);
        
        }
        static int fib(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return fib(n-2) + fib(n - 1);
        }
        static int lt2(int a, int n)
        {
            if (n == 0)
            {
                return 1;
            } else if(n > 0 && n % 2 == 0)
            {
                return lt2(a, n/2) * lt2(a, n/2);
            }
            else
            {
                return lt2(a, (n-1) / 2) * lt2(a, (n-1) / 2) * a;
            }
        }
        static int gcd(int a, int b)
        {
            if (a % b == 0)
            {
                return b;
            }
            return gcd(b, a % b);
        }
        static ulong bin(ulong n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n%2 + bin(n / 2)*10;
        }

        static void Main(string[] args)
        {
 
            Console.WriteLine(bin(45));
        }
    }
}