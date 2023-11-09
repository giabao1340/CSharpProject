using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Student
    {
        //Attibutes 
        private string studentId;
        private string name;
        private int birthYear;
        private bool gender;
        private string stdClass;

        //Constructor
        public Student() { }
        public Student(string studentId, string name, int birthYear, bool gender, string stdClass)
        {
            this.studentId = studentId;
            this.name = name;
            this.birthYear = birthYear;
            this.gender = gender;
            this.stdClass = stdClass;

        }
        //Methods
        public string GetStuendtId()
        {
            return studentId;
        }
        public void SetStudentId(string studentId)
        {
            this.studentId=studentId;
        }
        public string GetName()
        {
            return name;
        }   

        public int GetBirthYear()
        {
            return this.birthYear;
        }
        public void SetBirthYear(int birthYear)
        {
            int curentYears = DateTime.Now.Year;
            if (birthYear > curentYears || birthYear < 1990)
            {
                do
                {
                    Console.WriteLine("Nhap nam sinh hop le: ");
                    birthYear = int.Parse(Console.ReadLine());
                } while (birthYear > curentYears || birthYear < 1999);
            }
            this.birthYear = birthYear;
        }
        public bool GetGender()
        {
            return gender;
        }
        public void SetGender(bool gender)
        {
            this.gender = gender;
        }
        public string GetClass()
        {
            return stdClass;
        }
        public void SetClass(string stdClass)
        {
            this.stdClass = stdClass;
        }
        public void Input()
        {
            Console.Write("Nhap MSSV: ");
            studentId = Console.ReadLine();
            Console.Write("Nhap ho ten sinh vien: ");
            name = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            birthYear = int.Parse(Console.ReadLine());
            Console.Write("Nhap gioi tinh(nam/false nu/true): ");
            gender = bool.Parse(Console.ReadLine());
            Console.Write("Nhap lop sinh vien: ");
            stdClass = Console.ReadLine();
        }    
        public int GetAge() 
        {
            return DateTime.Now.Year - birthYear;
        }
        public void PrintInfor()
        {
            Console.WriteLine($"Student ID: {studentId}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Birth year: {birthYear}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Class: {stdClass}");
        }
    }
}
