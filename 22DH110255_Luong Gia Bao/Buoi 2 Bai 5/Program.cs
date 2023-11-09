using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_2_Bai_5
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
            a = new int[m, n];
            b = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                data = Console.ReadLine();
                nums = data.Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(nums[j]);
                }
            }
            for (int i = 0; i < m; i++)
            {
                data = Console.ReadLine();
                nums = data.Split(' ');
                for (int j = 0; j < n; j++)
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
        static double Eculid(int[,]a, int[,] b)
        {
            double e = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    e += Math.Pow(a[i, j] - b[i, j], 2);
                }
            }
            return Math.Round(Math.Sqrt(e), 2);
        }
        static void Main(string[] args)
        {
            int[,] a;
            int[,] b;
            NhapDuLieu(out a, out b);
            Console.WriteLine("Eculid = " + Eculid(a, b));
        }
    }
}
//2 2
//4 5
//6 7
//2 5
//8 1