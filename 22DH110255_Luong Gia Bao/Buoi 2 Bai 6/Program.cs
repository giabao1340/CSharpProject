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

            a = new int[m, m];
            b = new int[m, m];
            for (int i = 0; i < m; i++)
            {
                data = Console.ReadLine();
                nums = data.Split(' ');
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(nums[j]);
                }
            }
            for (int i = 0; i < m; i++)
            {
                data = Console.ReadLine();
                nums = data.Split(' ');
                for (int j = 0; j < m; j++)
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
        static int[,] MulMatrix(int[,] a, int[,] b)
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
        static int DotProduct(int[,] a, int[,] b)
        {
            int s = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    s += a[i, j] * b[i,j];
                }
            }
            return s;
        }
        static void Main(string[] args)
        {
            int[,] a, b;
            int s;
            NhapDuLieu(out a, out b);
            s = DotProduct(a, b);
            Console.WriteLine("Value : " + s);
            Console.ReadKey();
        }
    }
}
//3
//2 1 2
//1 1 1
//4 5 6
//4 5 6
//2 3 4
//1 2 3
