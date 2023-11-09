using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaTran
{
    internal class Program
    {
        static void Input(out int[,] a)
        {
            Console.Write("Nhap 1 <= n <= 5: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 5)
            {
                do
                {
                    Console.Write("Nhap 1 <= n <= 5: ");
                    n = int.Parse(Console.ReadLine());
                } while (n < 1 || n > 5);
            }
            a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Nhap A[{i}, {j}]: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                    if (a[i, j] < 1 || a[i, j] > 4)
                    {
                        do
                        {
                            Console.Write($"Nhap lai A[{i}, {j}]: ");
                            a[i, j] = int.Parse(Console.ReadLine());
                        } while (a[i, j] < 1 || a[i, j] > 4);
                    }

                }
            }
        }

        static void xuatMang(int[,] a)
        {

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    Console.Write($"A[{i},{j}] = {a[i, j],-5} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static int TongPhanTuLe(int[,]a, int k)
        {

            int s = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (a[k,i] % 2 != 0)
                {
                    s += a[k, i];
                }
            }
            return s;
        }
        static int gt(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * gt(n-1);
        }
        static void Main(string[] args)
        {
            int[,] a;
            Input(out a);
            xuatMang(a);
            Console.WriteLine("Nhap dong thu k: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("S = " + TongPhanTuLe(a, k));
            int x = gt(TongPhanTuLe(a, k));
            Console.WriteLine("Giai thua = "+x);
        }
    }
}