using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_2_Bai_3
{
    internal class Program
    {
        static void NhapDuLieu(out int[] a, out int[,] b)
        {
            Console.WriteLine("Nhap du lieu: ");
            string data = Console.ReadLine();
            string[] nums = data.Split(' ');
            int m = int.Parse(nums[0]);
            int n = int.Parse(nums[1]);
            a = new int[m];
            b = new int[m, n];
            data = Console.ReadLine();
            nums = data.Split(' ');
            for (int i = 0; i < m; i++)
            {
                a[i] = int.Parse(nums[i]);
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
        static int[] dotProduct(int[] a, int[,] b, ref int s)
        {
            int[] sum = new int[b.GetLength(1)];

                for (int i = 0; i < b.GetLength(1); i++)//7
                {
                    for (int j = 0; j < b.GetLength(0); j++) // 3
                    {
                        sum[i] += a[j] * b[j, i];
                    }
                    s += sum[i];
                }
            
            return sum;
        }//1 3 x 3 7 = 1 7 

        static void Main(string[] args)
        {
            int[] a;
            int[,]b;
            int s = 0;
            NhapDuLieu(out a, out b);
            int[] c = dotProduct(a, b, ref s);
            Console.WriteLine("Tong doanh thu: " + s);
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }
        }
    }
}
//3 7
//3 4 2
//34 12 15 11 10 2 15
//56 32 30 40 23 33 24
//6 13 12 20 15 19 8