using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanhThu
{
    internal class Program
    {
        static void NhapDuLieu(out int[,] table, out int[] prices)
        {
            Console.WriteLine("Nhap du lieu: ");
            StreamReader str = new StreamReader("D:/Data.txt");
            string line = str.ReadLine();
            string[] num = line.Split(' ');
            int types = int.Parse(num[0]);
            int days = int.Parse(num[1]);
            table = new int[types, days];

            line = str.ReadLine();
            num = line.Split(' ');
            prices = new int[types]; 

            for (int i = 0; i < types; i++)
            {
                prices[i] = int.Parse(num[i]);
            }
            for (int i = 0; i < types; i++)
            {
                line = str.ReadLine();
                num = line.Split(' ');
                for (int j = 0; j < days; j++)
                {
                    table[i, j] = int.Parse(num[j]);
                }
            }
        }
        static void XuatMang(int[,] table, int[] prices)
        {
            Console.WriteLine("Mang hai chieu: ");
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write($"A[{i},{j}] = {table[i, j],-5}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Mang mot chieu");
            for (int i = 0; i < prices.Length; i++)
            {
                Console.Write(prices[i] + " ");
            }
            Console.WriteLine();
        }
        static int[] DotProduct(int[,] table, int[] prices)
        {
            int[] doanhThu = new int[table.GetLength(1)];
            for (int i = 0; i < table.GetLength(1); i++) //4
            {
                for (int j = 0; j < table.GetLength(0); j++)//3
                {
                    doanhThu[i] += (table[j,i] * prices[j]);
                }
            }
            return doanhThu;
        }
        static int[] DotProduct2(int[,] table, int[] prices)
        {
            int[] doanhThu = new int[table.GetLength(0)];
            for (int i = 0; i < table.GetLength(0); i++) //3
            {
                for (int j = 0; j < table.GetLength(1); j++)//4
                {
                    doanhThu[i] += (table[i, j] * prices[i]);
                }
            }
            return doanhThu;
        }
        static void Print(int[,] table, int[] doanhThu)
        {
            Console.Write($"{null, -11}");
            for (int i = 0; i < table.GetLength(1); i++)
            {
                Console.Write($"|| Thu {i+2, -6}");
            }
            Console.WriteLine();

            for (int i = 0; i < table.GetLength(0); i++)
            {
                Console.Write($"Loai thu {i} || ");
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write($"{table[i, j],-9} || ");
                }
                Console.WriteLine();
            }
            Console.Write($"Tong{null, -7}||");

            for (int i = 0; i < table.GetLength(1); i++)
            {
                Console.Write($"{doanhThu[i], -10} ||");
            }
        }
        static void Main(string[] args)
        {
            int[,] table;
            int[] prices;
            NhapDuLieu(out table, out prices);
            int[] doanhThu = DotProduct(table, prices);
            Print(table, doanhThu);

        }
    }
}