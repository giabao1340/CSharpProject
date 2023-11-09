using System;
using System.Text;
namespace Bai5
{
    class Program
    {
        static void Input(out double[] a)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            a = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = double.Parse(Console.ReadLine());
            }
        }
        static void Output(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]}" + " ");
            }
            Console.WriteLine();
        }


        static void swap(ref double a, ref double b)
        {
            double box = a;
            a = b;
            b = box;
        }
        static void InterChange(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        swap(ref a[i], ref a[j]);
                    }
                }
            }
        }
        static void NumberfarX(double[] a)
        {
            int n = a.Length;
            Console.Write("Nhap x: ");
            double x = double.Parse(Console.ReadLine());
            InterChange(a);
            Console.Write("So xa voi x: ");
            if (x >= a[n/2])
            {

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] < x)
                    {
                        Console.Write(a[i]+" ");
                        break;
                    }
                }
            }

            if(x <= a[n/2])
            {
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    if (a[i] > x)
                    {
                        Console.WriteLine(+a[i] + " ");
                        break;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            double[] a;
            Input(out a);
            Console.Write("Array: ");
            Output(a);
            InterChange(a);
            Output(a);
            NumberfarX(a);
        }



    }



}
