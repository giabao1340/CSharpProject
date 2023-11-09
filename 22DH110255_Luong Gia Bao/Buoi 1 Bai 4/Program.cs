using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_1_Bai_2
{
    internal class Program
    {
        static void NhapDuLieu(out int[,] a, out int k)
        {
            Console.WriteLine("Nhap du lieu: ");
            string data = Console.ReadLine();
            string[] nums = data.Split(' ');
            int rows = int.Parse(nums[0]);
            int cols = int.Parse(nums[1]);
            k = int.Parse(nums[2]);
            a = new int[rows, cols];
            if (rows >= 1 && cols <= 100 && k >= 0 && k < rows)
            {
                for (int i = 0; i < rows; i++)
                {
                    data = Console.ReadLine();
                    nums = data.Split(' ');
                    for (int j = 0; j < cols; j++)
                    {
                        a[i, j] = int.Parse(nums[j]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid");
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
        static int sumRow(int[,] a, int k)//4a
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(1); i++)
            {
                sum += a[k, i];
            }
            return sum;
        }
        static int sumColum(int[,] a, int k)//4b
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                sum += a[i, k];
            }
            return sum;
        }
        static int SumArr(int[,] a, int k)//4c
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum += a[i, j];
                }
            }
            return sum;
        }
        static int SumChan(int[,] a, int k)//4d
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i,j] % 2 == 0)
                    {
                        sum += a[i, j];
                    }
                }
            }
            return sum;
        }
        static int Summle(int[,] a, int k)//4e
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] % 2 != 0)
                    {
                        sum += a[i, j];
                    }
                }
            }
            return sum;
        }
        static int Avg(int[,] a, int k)//4f
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum += a[i, j];
                }
            }
            return sum / a.Length;
        }
        static void Main(string[] args)
        {
            int[,] a;
            int k;
            NhapDuLieu(out a, out k);
            Console.WriteLine($"Tong cac phan tu tren dong {k}: {sumRow(a, k)}");
            Console.WriteLine($"Tong cac phan tu tren cot {k}: {sumColum(a, k)}");
            Console.WriteLine($"Tong tat ca cac phan tu: {SumArr(a, k)}");
            Console.WriteLine($"Tong tat ca cac phan tu chan: {SumChan(a, k)}");
            Console.WriteLine($"Tong tat ca cac phan tu le: {Summle(a, k)}");
            Console.WriteLine($"Gia tri trung binh: {Avg(a, k)}");

            Console.ReadKey();
        }
    }
}
//3 4 1
//4 5 6 4
//9 7 2 8
//2 5 7 3