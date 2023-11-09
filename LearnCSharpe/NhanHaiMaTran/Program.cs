using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NhanHaiMaTran
{
    internal class Program
    {
        static int[,] chuyenvi(ref int[,] a)
        {
            int[,] temp = a;
            a = new int[temp.GetLength(1), temp.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = temp[j, i];
                }
            }
            return a;
        }
        static void nhapMang(out int[,] a)
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
            nhapMang(out a);
            Console.WriteLine("chuyen vi");
            chuyenvi(ref a);
            xuatMang(a);
        }
    }
}
