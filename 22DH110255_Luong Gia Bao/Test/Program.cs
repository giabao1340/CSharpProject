using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void NhapDuLieu(out int[] a)
        {
            Console.WriteLine("Nhap du lieu: ");
            string data = Console.ReadLine();
            string[] nums = data.Split(' ');
            int m = int.Parse(nums[0]);

            a = new int[m];

            data = Console.ReadLine();
            nums = data.Split(' ');
            for (int i = 0; i < m; i++)
            {
                a[i] = int.Parse(nums[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] a;
            NhapDuLieu(out a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] +" ");
            }
        }
    }
}
//3
//1 2 3