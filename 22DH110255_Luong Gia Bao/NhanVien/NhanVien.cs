using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien
{
    internal class NhanVien
    {
        //Attribute
        private string maNV;
        private string hoTen;
        private double soNgayLV;
        // Constructor
        public NhanVien() { }
        public NhanVien(string maNV, string hoTen, double soNgayLV)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            if (soNgayLV < 0)
            {
                do
                {
                    Console.WriteLine("Nhap so ngay lam viec > 0: ");
                    soNgayLV = int.Parse(Console.ReadLine());
                } while (soNgayLV < 0);
            }
            this.soNgayLV = soNgayLV;
        }
        //property
        public double SoNgayLV
        {
            get { return soNgayLV; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid!");
                }
                else
                {
                    soNgayLV = value;
                }
            }
        }

        //Methods
        public virtual void Input()
        {
            Console.Write("Nhap ho ten nhan vien: ");
            hoTen   = Console.ReadLine();
            Console.Write("Nhap ma so nhan vien: ");
            maNV = Console.ReadLine();
            Console.Write("Nhap so ngay lam viec: ");
            soNgayLV = int.Parse(Console.ReadLine());

            if (soNgayLV < 0)
            {
                do
                {
                    Console.WriteLine("Nhap so ngay lam viec > 0: ");
                    soNgayLV = int.Parse(Console.ReadLine());
                } while (soNgayLV < 0);
            }
            Console.WriteLine();
        }
        public virtual double TinhLuong()
        {
            return soNgayLV * 100;
        }
        public override string ToString()
        {
            return $"Nhan vien [ MSNV: {maNV}, Ho ten nhan vien: {hoTen}, So ngay lam viec: {soNgayLV}, Luong = {TinhLuong()} USD]";
        }
    }
}