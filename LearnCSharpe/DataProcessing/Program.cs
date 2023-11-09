using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessing
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
        static void XuatDuLieu(int[,] a, int k)
        {
            if (k < 0 || k >= a.GetLength(0))
            {
                Console.WriteLine("Dong khong hop le");
            } else
            {
                Console.WriteLine();
                for (int i = 0; i < a.GetLength(1); i++)
                {
                    Console.Write(a[k,i]+" ");
                }
            }
        }
        static void Main(string[] args)
        {
            int[,] a;
            int k;
            NhapDuLieu(out a, out k);
            XuatDuLieu(a, k);
        }
    }
}
