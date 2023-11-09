using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2
{
    internal class Program
    {
        static int[,] NhapMang1()
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
        static void nhapMang2(out int[,] a)
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
        static void xuatMang2(int[,] a)
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
        static void nhapMang3(out int[,,] a) {
            Console.Write("Nhap hang ngang: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap hang doc: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Nhap cao: ");
            int z = int.Parse(Console.ReadLine());
            a = new int[x, y, z];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    for (int k = 0; k < z; k++)
                    {
                        Console.Write($"Nhap a[{i},{j},{k}]: ");
                        a[i, j, k] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine();
            }

        }
        static void xuatMang3(int[,,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    for (int k = 0; k < a.GetLength(2); k++)
                    {
                        Console.Write($"A[{i},{j},{k}] = {a[i, j, k],-5} ");
                    }
                }
                Console.WriteLine();
            }
        }


        static bool ktMatrix(int[,] a)
        {
            if (a.GetLength(0) == a.GetLength(1))
            {
                return true;
            }
            return  false;
        }
        static bool chuyenvi(int[,] a, int[,] b)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i,j] == b[j,i])
                    {
                        return true;
                    }
                }
            }
            return false;

        }
        static int[,] sumMatrix(int[,] a, int[,] b)
        {

            int[,] sum = new int[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum[i, j] = a[i, j] + b[i, j];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            // Ham tao 1 mang tra ve 1 mang gan mang a bang mang vua tao
            int[,] a;
            a = NhapMang1();
            xuatMang2(a);
            // tham chieu
            int[,] b;
            nhapMang2(out b);
            xuatMang2(b);
            // tham tri
            Console.Write("Nhap hang ngang: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap hang doc: ");
            int y = int.Parse(Console.ReadLine());
            int[,] c = new int[x, y];
            NhapMang3(c);
            xuatMang2(c);
        }
    }
}