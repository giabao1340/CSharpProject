using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMatrix
{
    internal class Program
    {
        static void NhapDuLieu(out int[,] a, out int[,]b)
        {
            Console.WriteLine("Nhap du lieu: ");
            string data = Console.ReadLine();
            string[] nums = data.Split(' ');
            int rows = int.Parse(nums[0]);
            int cols = int.Parse(nums[1]);
            a = new int[rows, cols];
            b = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                data = Console.ReadLine();
                nums = data.Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    a[i, j] = int.Parse(nums[j]);
                }
            }
            for (int i = 0; i < rows; i++)
            {
                data = Console.ReadLine();
                nums = data.Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    b[i, j] = int.Parse(nums[j]);
                }
            }
        }
        static int[,] SumMatrix(int[,] a, int[,] b)
        {
            int rowsa = a.GetLength(0);
            int colsa = b.GetLength(1);
            int[,] sum = new int[rowsa, colsa];
            for (int i = 0; i < rowsa; i++)
            {
                for (int j = 0; j < colsa; j++)
                {
                    sum[i, j] = a[i, j] + b[i, j];
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
            NhapDuLieu(out a, out b);
            Console.WriteLine("Sum of 2 matrix:");
            int[,] sum = SumMatrix(a, b);
            xuatMang(sum);
        }
    }
}
