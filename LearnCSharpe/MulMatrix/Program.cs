using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulMatrix
{
    internal class Program
    {
        static void NhapDuLieu(out int[,] a, out int[,] b)
        {
            Console.WriteLine("Nhap du lieu");
            string data = Console.ReadLine();
            string[] nums = data.Split(' ');
            int rowsa = int.Parse(nums[0]);
            int colsa = int.Parse(nums[1]);
            int rowsb = colsa;
            int colsb = int.Parse(nums[2]);
            a = new int[rowsa, colsa];
            b = new int[rowsb, colsb];
            for (int i = 0; i < rowsa; i++)
            {
                data = Console.ReadLine();
                nums = data.Split(' ');
                for (int j = 0; j < colsa; j++)
                {
                    a[i, j] = int.Parse(nums[j]);
                }
            }
            for (int i = 0; i < rowsb; i++)
            {
                data = Console.ReadLine();
                nums = data.Split(' ');
                for (int j = 0; j < colsb; j++)
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
        static int[,] MulMatrix(int[,] a, int[,] b)
        {
            int[,] mul = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < a.GetLength(1); k++)
                    {
                        int s = 0;
                        s = a[i,k] * b[k,j];
                        mul[i, j] += s;
                    }
                }
            }

            return mul;
        }
        static void Main(string[] args)
        {
            int[,] a, b;
            NhapDuLieu(out a, out b);
            Console.WriteLine("Mang A: ");
            xuatMang(a);
            Console.WriteLine("Mang B: ");
            xuatMang(b);
            Console.WriteLine("Tich hai ma tran:");
            xuatMang(MulMatrix(a, b));
        }
    }
}
//2 3 4
//1 2 3
//4 5 6
//1 2 3 4
//5 6 7 8
//1 2 3 4

//3 3 3
//2 -3 2
//0 1 -1
//-1 1 0
//1 0 1
//-1 1 0
//0 1 0
