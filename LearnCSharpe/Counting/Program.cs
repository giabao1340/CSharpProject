using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting
{
    internal class Program
    {
        static void Input(out int[] a)
        {
            Console.Write("Nhap n: ");
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
                Console.Write($"{a[i]}" + " ");
            }
            Console.WriteLine();
        }
        public static int max(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
        public static int[] counting(int[] a)
        {
            int m = max(a);
            int[] count = new int[m+1];
            for (int i = 0; i < a.Length; i++)
            {
                count[a[i]]++;
            }
            return count;
        }
        public static Dictionary<int,int> dictionary(int[] a)
        {
            Dictionary<int,int> dic = new Dictionary<int,int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (dic.ContainsKey(a[i]))
                {
                    dic[a[i]]++;
                } else
                {

                    dic.Add(a[i], 1);//
                }
            }
            return dic;
        }
        static void Main(string[] args)
        {
            int[] a;
            Input(out a);
            Output(a);
            Dictionary<int,int> count = dictionary(a);
            foreach (KeyValuePair<int, int> item in count)
                Console.WriteLine($"So {item.Key} xuat hien {item.Value} lan");
        }
    }
}