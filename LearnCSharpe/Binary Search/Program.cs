using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    internal class Program
    {
        static int  Binary_Search(int[] a, int x, int left, int right) 
        {
            int mid = (left + right)/2;
        if (x == a[mid])
            {
                return mid;
            }
            if (x < a[mid] && x > 0)
            {
                return Binary_Search(a, x, left, mid);
            }
            else if (x > a[mid] && x < a[left])
            {
                return Binary_Search(a, x, mid + 1, right);
            }
            else return -1;
        }
        
        static void Main(string[] args)
        {
            int[] a = {1, 2, 3, 4, 5 };
            int x = 3;
            int pos = Binary_Search(a, x, 0, a.Length - 1);
            Console.WriteLine(pos);
        }
    }
}
