using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devide_To_Conquer
{
    internal class Program
    {
        static int min(int[] a, int left, int right)
        {
            int k = (left + right)/2;
            if (left == right)
            {
                return a[right];
            }
            int minLeft = min(a, left, k);
            int minRight = min(a, k+1, right);
            return Math.Min(minLeft, minRight);
        }
        static void Main(string[] args)
        {
            int[] a = {5, 17, 82, 9, 3, 2, 7 };
            int minArr = min(a, 0, a.Length - 1);
            Console.WriteLine(minArr);
        }
    }
}