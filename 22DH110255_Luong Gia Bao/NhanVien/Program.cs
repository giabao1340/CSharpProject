using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVienBH nv1 = new NhanVienBH();
            nv1.Input();
            Console.WriteLine(nv1.ToString());
            NhanVienBH nv2 = new NhanVienBH("22DH123456", "Pham Minh Hung", 27, 19.0);
            Console.WriteLine(nv2.ToString());
        }
    }
}
