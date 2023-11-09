using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace OOP

{

    internal class Program
    {
        static void Main(string[] args)
        {
            //khoi tao doi tuong constructors(gia tri Mac Dinh)
            //Student sv1 = new Student();//1 object
            //sv1.Input();
            Student sv2 = new Student("22DH110255", "Luong Gia Bao", 2004, false, "TH2310");
            sv2.PrintInfo();
            sv2.SetBirthYear(1945);
            sv2.BirthYear = 2003;
            sv2.PrintInfo();
            //Console.WriteLine(sv2.GetBirthYear());
            //sv1.SetBirthYear(-5);//method
            //sv2.BirthYear = 2004;//properties
            //Console.WriteLine(sv2.GetBirthYear());//su dung method
            //Console.WriteLine(sv1.BirthYear);// su dung properties
            //Console.WriteLine($"MSSV{null,-11}|| Ho Ten{null,-18}|| Nam sinh {null,-5}|| Gioi tinh{null,-5}|| Lop ");
            //sv1.ListStudent();
            //sv2.ListStudent();
            
            Console.ReadKey();
        }
    }
}