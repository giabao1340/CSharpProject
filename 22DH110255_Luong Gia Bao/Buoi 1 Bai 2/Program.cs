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
            } else
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
        static void Main(string[] args)
        {
            int[,] a;
            int k;
            NhapDuLieu(out a, out k);
            //xuatMang(a);
            Console.WriteLine($"Dong thu {k} cua mang: ");
            for (int i = 0; i < a.GetLength(1); i++)
            {
                Console.Write(a[k, i]+" ");
            }
            Console.ReadKey();
        }
    }
}
//3 4 1
//4 5 6 4
//9 7 2 8
//2 5 7 3