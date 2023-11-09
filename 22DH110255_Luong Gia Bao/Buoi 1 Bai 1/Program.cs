using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2
{
    internal class Program
    {
        static void NhapMang1(out int[,] a)
        {
            Console.Write("Nhap hang ngang: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap hang doc: ");
            int y = int.Parse(Console.ReadLine());
            a = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"Nhap a[{i},{j}]: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }
        static int[,] NhapMang2()
        {
            Console.Write("Nhap hang ngang: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap hang doc: ");
            int y = int.Parse(Console.ReadLine());
            int[,] b = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"Nhap a[{i},{j}]: ");
                    b[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            return b;
        }

        static int[,] NhapMang3(int[,] c)
        {
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write($"Nhap a[{i},{j}]: ");
                    c [i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            return c;
        }
        static void xuatMang(int[,] a)
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
        static void Main(string[] args)
        {
            int[,] a;
            NhapMang1(out a);
            xuatMang(a);

            int[,] b;
            b = NhapMang2();
            xuatMang(b);

            Console.Write("Nhap hang ngang: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap hang doc: ");
            int y = int.Parse(Console.ReadLine());
            int[,] c = new int[x, y];
            NhapMang3(c);
            xuatMang(c);
            Console.ReadKey();
        }
    }
}