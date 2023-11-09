using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
			int n = int.Parse(Console.ReadLine());
            try
			{
				for (int i = n; i >= 0 ; i--)
				{
                    Console.WriteLine(n/i);
                }
			}
			catch (Exception)
			{
                Console.WriteLine("sthg");
                throw;
			}
        }
    }
}
