using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessing
{
    internal class Program
    {
        static void NhapDuLieu(out int[,] a)
        {
            Console.WriteLine("Nhap du lieu: ");
            string data = Console.ReadLine();
            string[] nums = data.Split(' ');
            int rows = int.Parse(nums[0]);
            int cols = int.Parse(nums[1]);
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

        static double tbsv(int[,]a, int k)
        {
            double sum = 0;
            for (int i = 0; i < a.GetLength(1); i++)
            {
                sum += a[k, i];
            }
            double tb = sum / a.GetLength(1);
            return tb;
        }

        static double tbmh(int[,] a, int k)
        {
            double sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                sum += a[i,k];
            }
            double tb = sum / 5;
            return tb;
        }

        static void XuatDuLieu(int[,] a)
        {
            string[] name = { "Nguyen Van A", "Truong Van B", "Tran Thi C", "Le Thi D", "Huynh Van E" };
            Console.WriteLine($"{null, -15}Toan{null,-6}Ly{null,-8}Hoa{null,-7}TBSV");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.Write($"{name[i], -16}");
                    }
                    Console.Write($"{a[i, j],-8}  ");
                    if (j == a.GetLength(1)-1)
                    {
                        Console.Write("| " +tbsv(a, j));
                    }
                }
                Console.WriteLine();

            }
            Console.WriteLine("----------------------------------------------");
            Console.Write($"TBMH:{null,-11}");
            for (int i = 0; i < a.GetLength(1); i++)
            {
                Console.Write($"{tbmh(a, i), -9} ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[,] a;
            NhapDuLieu(out a);
            XuatDuLieu(a);
        }
    }
}
