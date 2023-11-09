using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Program
    {
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
        static int[,] SumMatrix(int[,] a, int[,] b)
        {
            int rowsa = a.GetLength(0);
            int colsa = b.GetLength(1);
            int[,] sum = new int[rowsa,colsa];
            for (int i = 0; i < rowsa; i++)
            {
                for (int j = 0; j < colsa; j++)
                {
                    sum[i,j] = a[i,j] + b[i,j];
                }
            }
            return sum;
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
            int[,] b;
            Console.WriteLine("Nhap mang thu nhat: ");
            nhapMang2(out a);
           // Console.WriteLine("Mang vua nhap: ");
            //xuatMang(a);

            Console.WriteLine("Nhap mang thu hai: ");
            nhapMang2(out b);
            //Console.WriteLine("Mang vua nhap: ");
            //xuatMang(b);
            int rowsa = a.GetLength(0);
            int colsa = b.GetLength(1);
            int rowsb = b.GetLength(0);
            int colsb = b.GetLength(1);
            int[,] sum= SumMatrix(a, b);
            if (rowsa != rowsb || colsa != colsb)
            {
                Console.WriteLine("Error 404!");
            } else
            {
                Console.WriteLine("Sum of 2 Matrix:");
                xuatMang(sum);
            }
        }
    }
}
