using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OOP
{
    internal class Student
    {
        //Attibutes /fields
        private string studentId;
        private string name;
        private int birthYear;
        private bool gender;
        private string stdClass;


        //Dinh nghia Constructors de khoi tao doi tuong
        //Khong tra ve
        //Su dung ten lop dat ten constructors
        public Student() { }//tao constructors mac dinh 
        public Student(string studentId, string name, int birthYear, bool gender, string stdClass)
        {
            this.studentId = studentId;
            this.name = name;
            this.birthYear = birthYear;
            this.gender = gender;
            this.stdClass = stdClass;

            // studenId cua thuoc tinh = studentId cua tham so
        }
        //Methods
        public string GetStudentId() 
        {
            Console.WriteLine(studentId);
            return studentId;
        }
        public string GetName()
        {
            Console.WriteLine(name);
            return name;
        }
        public int GetBirthYear()
        {
            Console.WriteLine(birthYear);
            return birthYear;
        }
        public bool GetGender() 
        {
            Console.WriteLine(gender);
            return gender;
        }
        public string GetStdClass()
        {
            Console.WriteLine(stdClass);
            return stdClass;
        }
        public void SetStdID(string stdID)
        {
            this.studentId = stdID;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetGender(string name)
        {
            this.name = name;
        }
        public void SetBirthYear(int birthYear)
        {
            int curentYears = DateTime.Now.Year;
            if (birthYear < 1990 || birthYear > curentYears)
            {
                Console.WriteLine("Nam sinh khong hhop le");
            }
            else
            {
                this.birthYear = birthYear;
            }
        }
        public void SetGende(bool gender)
        {
            this.gender = gender;
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
        public void PrintInfo()
        {
            Console.WriteLine("MSSV: " +StudenId);
            Console.WriteLine("Ho ten: " +name);
            Console.WriteLine("Nam sinh: " + birthYear);
            Console.WriteLine("Gioi tinh:" + Gender);
            Console.WriteLine("Lop: " + StdClass);
        }
        //Properties: ten dai dien
        //truy cap cac attribute ben ngoai class
        public string StudenId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int BirthYear
        {
            get { return birthYear; }

            set
            {
                int curentYears = DateTime.Now.Year;
                if (value < 1990 || value > curentYears)
                {
                    Console.WriteLine("Nam sinh khong hhop le");
                }
                else 
                {
                    birthYear = value;
                }
            }

        }
        public bool Gender
        {
            get { return gender; }
            set
            {
                gender = value;
            }
        }
        public string StdClass
        {
            get { return stdClass; }
            set
            {
                stdClass = value;
            }
        }
    }
}
