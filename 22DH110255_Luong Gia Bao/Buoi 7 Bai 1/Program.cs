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

            Staff staff = new Staff("Nguyen Van A", 1990, "HCM", "CNTT", 2500);

            Console.WriteLine(student.ToString());
            Console.WriteLine(staff.ToString());
            Console.ReadKey();
        }
    }
}
