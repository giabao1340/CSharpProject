using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Input();
            student.ToString();
            staff staff = new staff();
            staff.Input();
            staff.ToString();
            Console.WriteLine(student.ToString());
            Console.WriteLine(staff.ToString());
            Console.ReadKey();
        }
    }
}
