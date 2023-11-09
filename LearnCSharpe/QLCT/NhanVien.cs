using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCT
{
    internal abstract  class NhanVien
    {
        //Attribute
        private string maNV;
        private string hoTen;
        private int namVaoLam;
        private double hsLuong;
        public static double luongCB;
        //Properties
        public int NamVaoLam
        {
            get { return namVaoLam; }
        }
        public double HsLuong
        {
            get { return hsLuong; }
            set
            {
                if (value <= 1.35)
                {
                    hsLuong = 1.35;
                    Console.WriteLine("He so luong thap hon muc toi thieu");
                }
                hsLuong = value;
            }
        }
        public double LuongCB
        {
            get { return luongCB; }
            set
            {
                if (value <= 0)
                {
                    luongCB = 1500000;
                    Console.WriteLine("Luong co ban khong hop le");
                }
                luongCB = value;
            }
        }
        //Constructor
        public NhanVien() { }
        public NhanVien(string maNV, string hoTen, int namVaoLam, double hsLuong)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            if (namVaoLam < 2010 && namVaoLam > DateTime.Now.Year)
            {
                this.namVaoLam = 2010;
                Console.WriteLine("Nam vao lam khong hop le");
            }
            this.namVaoLam = namVaoLam;
            this.hsLuong = hsLuong;
        }
        //Method
        public int TinhThamNien(int namVaoLam)
        {
            int now = DateTime.Now.Year;
            return now - namVaoLam;
        }
        public abstract double TinhLuong();
        public virtual string toString()
        {
            return $"Nhan vien[{maNV}, {hoTen}, {namVaoLam}, {hsLuong} ";
        }
    }
}
