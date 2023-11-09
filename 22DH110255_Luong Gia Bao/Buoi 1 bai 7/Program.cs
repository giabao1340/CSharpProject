using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_1_bai_7
{
    internal class Program
    {
        static void NhapDuLieu(out int[,] a)
        {
            Console.WriteLine("Nhap du lieu: ");
            string data = Console.ReadLine();
            string[] nums = data.Split(' ');
            int size = int.Parse(nums[0]);
            a = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                data = Console.ReadLine();
                nums = data.Split(' ');
                for (int j = 0; j < size; j++)
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
        static void dcc(int[,] a)
        {
            Console.WriteLine("Duong cheo chinh: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(+a[i,j]+" ");
                    }
                }
            }
            Console.WriteLine();
        }
        static void dcp(int[,] a)
        {
            Console.WriteLine("duong cheo phu:");
            int k = a.GetLength(0);
            for (int i = 0; i < k; i++)
            {
                Console.Write(a[i, k - i-1]+" ");
            }
            Console.WriteLine();
        }
        static void maTranTamGiac(int[,] a)
        {
            int k = a.GetLength(0);
            Console.WriteLine("Ma tran tam giac: ");
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (i <= j)
                    {
                        Console.Write(a[i,j]+" ");
                    } else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine(  );
            }
        }
        static void Main(string[] args)
        {
            int[,] a;
            NhapDuLieu(out a);
            //xuatMang(a);
            dcc(a);
            dcp(a);
            maTranTamGiac(a);
        }
    }
}
//3
//1 2 3
//4 5 6
//7 8 9