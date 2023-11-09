using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHaNoi
{
    internal class Program
    {
        static string ToH(int n, string A, string C, string B)
        {
            string kq = "";
            if (n == 1) {
                kq += $" {A} -> {C}\n ";
            } else{
            
                kq += ToH(n-1, A, B, C) ;
                kq += ToH(1, A, C, B);
                kq += ToH(n - 1, B, C, A);
            }
            return kq;
        }
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("D:/kq.txt");
            string a = "A";
            string b = "B";
            string c = "C";
            Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            sw.WriteLine(ToH(n, a, c, b));
            sw.Close();
        }
    }
}
