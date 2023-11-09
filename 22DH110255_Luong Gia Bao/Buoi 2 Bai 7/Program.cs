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
            int k = int.Parse(nums[2]);
            a = new int[m, n];
            b = new int[k, k];
            for (int i = 0; i < m; i++)
            {
                data = Console.ReadLine();
                nums = data.Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(nums[j]);
                }
            }
            for (int i = 0; i < k; i++)
            {
                data = Console.ReadLine();
                nums = data.Split(' ');
                for (int j = 0; j < k; j++)
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
            int[,] temp = new int[b.GetLength(0), b.GetLength(1)];

            for (int index1 = i ; index1 < a.GetLength(0)-i; index1++)
            {
                for (int index2 = j; index2 < b.GetLength(1); index2++)
                {
                    pt += temp[index1, index2] * b[index2, index1];
                }
            }
            return pt;
        }
        static int[,] TichChap(int[,] a, int[,] b)
        {
            int i = 0, j = 0;
            int size1 = a.GetLength(0) - b.GetLength(0);
            int size2 = a.GetLength(1) - b.GetLength(0);
            int[,] c = new int[size1, size2];
            for (i = 0; i < size1; i++)
            {
                for (j = 0; j < size2; j++)
                {
                    c[i, j] = dotProduct(a, b, i, j);
                }
            }
            return c;
        }
        static void Main(string[] args)
        {
            int[,] a, b;
            int pt = 0;
            NhapDuLieu(out a, out b);
            Console.WriteLine(pt);
        }
    }
}
//4 4 3
//4 2 2 4
//1 9 5 3
//1 4 2 4
//0 9 8 1
//-1 -1 -1
//-1 8 -1
//-1 -1 -1


//3 3 3
//4 2 2
//1 9 5
//1 4 2
//-1 -1 -1
//-1 8 -1
//-1 -1 -1

//static int[,] TichMaTran(int[,] a, int[,] b)
//{
//    int[,] sum = new int[a.GetLength(0), b.GetLength(1)];
//    for (int i = 0; i < a.GetLength(0); i++)// i -> 2
//    {
//        for (int j = 0; j < b.GetLength(1); j++)//j -> 3
//        {
//            sum[i, j] = dotProduct(a, b, i, j);
//        }
//    }
//    return sum;
//}// 1 2 x 2 3 = 1 3
//static int[,] MulMatrix(int[,] a, int[,] b)
//{
//    int[,] sum = new int[a.GetLength(0), b.GetLength(1)];
//    for (int i = 0; i < a.GetLength(0); i++)//1
//    {
//        for (int j = 0; j < b.GetLength(1); j++)//3
//        {
//            for (int k = 0; k < a.GetLength(1); k++)//2
//            {
//                sum[i, j] += a[i, k] * b[k, j];
//            }
//        }
//    }
//    return sum;
//}// 1 2 x 2 3 = 1 3