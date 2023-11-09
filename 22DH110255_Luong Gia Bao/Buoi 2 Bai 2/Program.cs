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
        static void NhapDuLieu(out int[,] a, out int[,] b)
        {
            Console.WriteLine("Nhap du lieu: ");
            string data = Console.ReadLine();
            string[] nums = data.Split(' ');
            int m = int.Parse(nums[0]);
            int n = int.Parse(nums[1]);
            int p = int.Parse(nums[2]);
            a = new int[m, n];
            b = new int[n, p];
            for (int i = 0; i < m; i++)
            {
                data = Console.ReadLine();
                nums = data.Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(nums[j]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                data = Console.ReadLine();
                nums = data.Split(' ');
                for (int j = 0; j < p; j++)
                {
                    b[i, j] = int.Parse(nums[j]);
                }
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
        static int dotProduct(int[,] a, int[,] b, int i, int j)
        {
            int pt = 0;
            for (int k = 0; k < a.GetLength(1); k++)
            {
                pt += a[i, k] * b[k, j];
            }
            return pt;
        }
        static int[,] TichMaTran(int[,] a, int[,] b)
        {
            int[,] sum = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)// i -> 2
            {
                for (int j = 0; j < b.GetLength(1); j++)//j -> 3
                {
                    sum[i, j] = dotProduct(a, b, i, j);
                }
            }
            return sum;
        }// 1 2 x 2 3 = 1 3
        static int[,] MulMatrix(int[,] a, int[,]b)
        {
            int[,] sum = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)//1
            {
                for (int j = 0; j < b.GetLength(1); j++)//3
                {
                    for (int k = 0; k < a.GetLength(1); k++)//2
                    {
                        sum[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return sum;
        }// 1 2 x 2 3 = 1 3
        static void Main(string[] args)
        {
            int[,] a, b;
            NhapDuLieu(out a, out b);
            //xuatMang(a);
            //xuatMang(b);
            int[,] sum = TichMaTran(a, b);
            xuatMang(sum);
            Console.ReadKey();
        }
    }
}
//2 2 3
//1 2
//3 4
//5 6 7
//8 9 10
