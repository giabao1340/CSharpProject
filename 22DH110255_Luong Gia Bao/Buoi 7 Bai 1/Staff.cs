using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Staff: Person
    {
        //attribute
        string department;
        double salary;
        //constructor
        public Staff() { }
        public Staff(string name, int birthYear, string adress, string department, double salary): base(name, birthYear, adress)
        { 
        this.department = department;
        this.salary = salary;
        }
        //Mehtod
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap phong ban: ");
            department = Console.ReadLine();
            Console.WriteLine("Nhap muc luong");
            salary = double.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Staff [{base.ToString()} - Department: {department}  salary: {salary}";
        }
        public void  UpdateSalary(double salary)
        {
            this.salary = salary;
        }
    }
}
