
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void NhapMang(out int[,] a)
        {
            string line = Console.ReadLine();
            string[] num = line.Split(' ');
            int row = int.Parse(num[0]);
            int col = int.Parse(num[1]);
            a = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                line = Console.ReadLine();
                num = line.Split(' ');
                for (int j = 0; j < col; j++)
                {
                    a[i, j] = int.Parse(num[j]);
                }
            }
        }
        static void XuatMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"A[{i},{j}] = {a[i,j], -5}");
                }
                Console.WriteLine();
            }
        }
        static void XuatTheoDong(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"Dong {i}: A[{i},{j}] = {a[i, j],-5}");
                }
                Console.WriteLine();
            }
        }
        static void XuatTheoCot(int[,] a)
        {
            for (int i = 0; i < a.GetLength(1); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    Console.Write($"Cot {i}: A[{j},{i}] = {a[j, i],-5}");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] a;
            NhapMang(out a);
            XuatTheoDong(a);
            XuatTheoCot(a);
        }
    }
}
//3 4
//1 3 2 4
//5 3 8 9
//3 4 7 2