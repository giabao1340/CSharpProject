using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Student : Person
    {
        //Attribute
        private string program;
        private int year;
        //Construcor
        public Student():base() { } 
        public Student(string name, int birthYear, string address, string program, int year) : base(name, birthYear, address)
        { 
            this.program = program;
            this.year = year;
        }
        //Method
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap chuong trinh hoc: ");
            program = Console.ReadLine();
            Console.Write("Sinh vien nam thu: ");
            year = int.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Student [{base.ToString()} - Program: {program}  Year: {year}";
        }
    }
}
