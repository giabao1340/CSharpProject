using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberNear
{
    internal class Program
    {
        static void NhapMang(out int[] a)
        {
            Console.WriteLine("Nhap Mang");
            StreamReader streamReader = new StreamReader("D:/output.txt");
            string s = streamReader.ReadLine();
            string[] arr = s.Split(' ');
            a = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                a[i] = int.Parse(arr[i]);
            }
        }
        static void XuatMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] +" ");
            }
            Console.WriteLine();
        }
        static void NumberNearX(int[] a, int x)
        {
            Console.Write("Number near x: ");
            int[] distance = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                distance[i] = Math.Abs(x - a[i]);
            }
            int min = distance[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (distance[i] < min)
                {
                    min = distance[i];
                }
            }
            for(int i = 0; i < distance.Length; i++)
            {
                if (distance[i] == min)
                {
                    Console.Write(a[i] +" ");
                }
            }
        }
        static void NumberFarX(int[] a, int x)
        {
            Console.Write("Number far x: ");
            int[] distance = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                distance[i] = Math.Abs(x - a[i]);
            }
            int max = distance[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (distance[i] > max)
                {
                    max = distance[i];
                }
            }
            for (int i = 0; i < distance.Length; i++)
            {
                if (distance[i] == max)
                {
                    Console.Write(a[i] + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a;
            
            NhapMang(out a);
            XuatMang(a);
            Console.Write("Nhap x: ");
            int x = int.Parse(Console.ReadLine());
            NumberNearX(a, x);
            Console.WriteLine();
            NumberFarX(a, x);
            Console.WriteLine();
        }
    }
}
