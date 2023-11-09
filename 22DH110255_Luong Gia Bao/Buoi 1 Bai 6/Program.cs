using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_1_Bai_6
{
    internal class Program
    {   
        static void NhapDuLieu(out int[,] a, out int m, out int n)
        {
            Console.WriteLine("Nhap du lieu: ");
            string data = Console.ReadLine();
            string[] nums = data.Split(' ');
            int rows = int.Parse(nums[0]);
            int cols = int.Parse(nums[1]);
            m = int.Parse(nums[2]);
            n = int.Parse(nums[3]);
            a = new int[rows, cols];
            if (rows >= 1 && cols <= 100 && m >= 0 && m < rows && n >= 0 && n < rows)
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
        static void swap(ref int a,ref int b)
        {
            int box;
            box = a;
            a = b;
            b = box;
        }
        static void SortRow(int[,] a, int k)
        {
            for (int i = 0; i < a.GetLength(1);i++)
            {
                for (int j = 0; j < a.GetLength(1) - 1; j++)
                {
                    if (a[k, j] > a[k, j + 1])
                    {
                        swap(ref a[k, j], ref a[k, j + 1]);
                    }
                }
            }
        }
        static void SortCol(int[,] a, int k)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0)-1; j++)
                {
                    if (a[j, k] < a[j+1, k])
                    {
                        swap(ref a[j, k], ref a[j + 1, k]);
                    }
                }
            }
        }
        static void ChangePos(int[,] a, int m, int n)
        {
            int[] b = new int[a.GetLength(0)];
            for (int i = 0; i < a.GetLength(1) ; i++)
            {
                swap(ref a[m, i], ref a[n, i]);
            }
        }
        static void Sort(int[,] a)
        {
            for (int m = 0; m < a.GetLength(0); m++)
                for (int n = 0; n < a.GetLength(1); n++)
                    for (int p = 0; p < a.GetLength(0); p++)
                        for (int q = 0; q < a.GetLength(1); q++)
                            if (a[m,n] < a[p,q])
                                swap(ref a[m,n], ref a[p,q]);
        }
        static void Main(string[] args)
        {
            int[,] a;
            int m, n;
            NhapDuLieu(out a, out m, out n);
            //SortRow(a, m);//6a
            //SortCol(a, m);//6b
            //ChangePos(a, m, n);//6d
            Sort(a);//6e
            xuatMang(a);
            Console.ReadKey();
        }
    }
}
//3 4 1 2
//4 5 6 4
//9 7 2 8
//2 5 7 3

