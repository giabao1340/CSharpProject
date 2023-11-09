using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCT
{
    internal class QuanLy : NhanVien
    {
        //Attribute
        private int capBac;
        static int baseSalary = 1000;
        //Constructor
        public QuanLy() { }
        public QuanLy(string maNV, string hoTen, int namVaoLam, double hsLuong, int capBac) : base(maNV, hoTen, namVaoLam, hsLuong)
        {
            if (capBac != 0 || capBac != 1 || capBac != 2 ||capBac != 3)
            {
                this.capBac = 0;
            }
            this.capBac = capBac;
        }

        public override double TinhLuong()
        {
            switch (capBac)
            {
                case 0: return LuongCB * 1.3;
                case 1: return LuongCB * 1.5;
                case 2: return LuongCB * 1.8;
                case 3: return LuongCB * 2.3;
            }
            return LuongCB;
        }
        public override string toString()
        {
            switch (capBac)
            {
                case 0: return $"{base.toString()} - Pho phong]";
                case 1: return $"{base.toString()} - Truong phong]";
                case 2: return $"{base.toString()} - Pho giam doc]";
                case 3: return $"{base.toString()} - Giam doc]";
//                default: return $"{base.toString()} - Nhan Vien";
            }
            return base.toString() +" - Nhan vien]";
        }
    }
}
