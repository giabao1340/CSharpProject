using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] distance = new int[n];
            for (int i = 0; i < n; i++)
            {
                distance[i] = Math.Abs(n - (int)Math.Pow(2, i));
            }
            int min = distance[0];

            for (int i = 1; i < n; i++)
            {
                if (distance[i] < min)
                {
                    min = distance[i];
                }
            }
            Console.WriteLine(min);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(distance[i]);
            }


            //for (int i = 0; i < distance.Length; i++)
            //{
            //    if (distance[i] == min)
            //    {
            //        Console.Write((int)Math.Pow(2,i));
            //    }
            //}
        }
    }
}
