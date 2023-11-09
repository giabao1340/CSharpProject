using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_1_Bai_3
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
            if (rows >= 1 && cols <= 100)
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
        static int MaxRowk(int[,]a, int k)
        {
            int max = a[k, 0];
            for (int i = 1; i < a.GetLength(1); i++)
            {
                if (a[k,i]> max)
                {
                    max = a[k, i];
                }
            }
            return max;
        }
        static int MinRowk(int[,] a, int k)
        {
            int min = a[k, 0];
            for (int i = 1; i < a.GetLength(1); i++)
            {
                if (a[k, i] < min)
                {
                    min = a[k, i];
                }
            }
            return min;
        }
        static bool ktSnt(int n)
        {
            if (n < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                        return false;
                }
                return true;
            }
        }
        static int sumSnt(int[,] a)
        {
            int s = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (ktSnt(a[i, j]) == true)
                    {
                        s += a[i, j];
                    }
                }
            }
            return s;
        }
        static void Main(string[] args)
        {
            int[,] a;
            int k;
            NhapDuLieu(out a, out k);
            //5a
            Console.WriteLine($"Max row {k} : "+MaxRowk(a, k));
            //5b
            Console.WriteLine($"Min row {k} : " + MinRowk(a, k));
            //5c
            Console.WriteLine($"Sum = {sumSnt(a)}");
            Console.ReadKey();
        }
    }
}
//3 4 1
//4 5 6 4
//9 7 2 8
//2 5 7 3