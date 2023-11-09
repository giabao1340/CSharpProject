using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dcp
{
    internal class Program
    {
        static void NhapMaTran(out int[,] a)
        {
            Console.Write("Nhap kich thuoc mang: ");
            int x = int.Parse(Console.ReadLine());
            a = new int[x, x];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write($"Nhap A[{i}, {j}]: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void InMaTran(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"A[{i}, {j}] = {a[i, j], -5}");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] a;
            NhapMaTran(out a);
            InMaTran(a);
            //TimMinDCP(a);
        }
    }
}
