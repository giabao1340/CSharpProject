using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamGiacCan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n-i; j++)
                {
                    Console.Write("   ");
                }
                for (int j = n; j > n-i; j--)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}
