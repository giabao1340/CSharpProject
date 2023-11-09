using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVien.luongCB = 1500000;
            QuanLy nv = new QuanLy("A01", "Nguyen B", 2011, 1.3, -1);
            QuanLy ql = new QuanLy("A02", "Nguyen Van A", 2010, 2.3, 3);
            Console.WriteLine(nv.toString());
            Console.WriteLine(ql.toString());
            double luongNV = nv.TinhLuong();
            double luongQL = ql.TinhLuong();
            Console.WriteLine("Luong nhan vien: " + luongNV);
            Console.WriteLine("Luong quan ly: " + luongQL);
        }
    }
}
