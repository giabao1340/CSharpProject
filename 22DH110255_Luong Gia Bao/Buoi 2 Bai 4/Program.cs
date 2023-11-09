using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_2_Bai_4
{
    internal class Program
    {
        static void NhapDuLieu(out int[,] a)
        {
            Console.WriteLine("Nhap du lieu: ");
            string data = Console.ReadLine();
            string[] nums = data.Split(' ');
            int m = int.Parse(nums[0]);
            int n = int.Parse(nums[1]);
            a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                data = Console.ReadLine();
                nums = data.Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(nums[j]);
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
        static int[,] ChuyenVi(int[,] a) // 3 4
        {
            int[,] cv = new int[a.GetLength(1),a.GetLength(0)];//4 3
            for (int i = 0; i < a.GetLength(1); i++)// i -> 4
            {
                for (int j = 0; j < a.GetLength(0); j++)// i -> 3
                {
                    cv[i, j] = a[j, i];
                }
            }
            return cv;
        }
        static void Main(string[] args)
        {
            int[,] a;
            NhapDuLieu(out a);
            int[,] cv = ChuyenVi(a);
            xuatMang(cv);
        }
    }
}
