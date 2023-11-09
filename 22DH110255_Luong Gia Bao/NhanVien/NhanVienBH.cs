using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien
{
    internal class NhanVienBH:NhanVien
    {
        //attribute
        private double hsThuong;

        //Constructor
        public NhanVienBH() { }
        public NhanVienBH(string maNV, string hoTen, double soNgayLV, double hsThuong) : base(maNV, hoTen, soNgayLV) 
        { 
            if (hsThuong <= 0 || hsThuong > 10)
            {
                do
                {
                    Console.Write("Nhap he so luong hop le: ");
                    hsThuong = double.Parse(Console.ReadLine());
                } while (hsThuong <= 0 || hsThuong > 10);
            }
            this.hsThuong = hsThuong;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap he so luong: ");
            hsThuong = double.Parse(Console.ReadLine());
            if (hsThuong <= 0  || hsThuong > 10) 
            {
                do
                {
                    Console.Write("Nhap he so luong hop le: ");
                    hsThuong = double.Parse(Console.ReadLine());
                } while (hsThuong <= 0 || hsThuong > 10);
            }
        }
        public override string ToString()
        {
            return base.ToString() +$" He so Thuong: {hsThuong}";
        }
        public override double TinhLuong()
        {
            return base.TinhLuong() + hsThuong*6;
        }
    }
}
