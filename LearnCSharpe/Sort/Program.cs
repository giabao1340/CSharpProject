using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal class Program
    {
        static void SelecSort(int[] a)
        {
            for (int i = 0;i < a.Length-1; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[j] < a[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = a[minIndex];
                a[minIndex] = a[i];
                a[i] = temp;    
            }
        }
        static void BubbleSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length - i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j]   = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static void Input(out int[] a)
        {
            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Output(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"a[{i}] = " + a[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] a;
            Input(out a);
            Console.WriteLine("After sort: ");
            SelecSort(a);
            Output(a);
        }
    }
}
