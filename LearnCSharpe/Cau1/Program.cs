using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Cau1
{
    internal class Program
    {
        static void ReadMatrix(out int[,] a)
        {
            int m, n;
            do
            {
                Console.Write("Nhap so dong: ");
                m = int.Parse(Console.ReadLine());
            } while (m <= 0 || m > Math.Pow(m, 6));
            do
            {
                Console.Write("Nhap so cot: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n > Math.Pow(m, 6));
            a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Nhap a[{i},{j}]: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }
        static void PrintMatrix(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"A[{i},{j}] = {a[i, j],-5} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static int CountGreater(int[,] a, int k)
        {
            int count= 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i,j] > k)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[,] a;
            ReadMatrix(out a);
            PrintMatrix(a);
            Console.WriteLine("Nhap k");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine($"Co {CountGreater(a, k)} phan tu lon hon {k}");
            Console.WriteLine($"Cac phan tu lon hon {k}");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > k)
                    {
                        Console.Write($"A[{i},{j}] = {a[i, j],-5} ");
                    }
                }
            }
        }
    }
}
