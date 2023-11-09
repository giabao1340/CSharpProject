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
            Student student = new Student();
            student.Input();
            student.PrintInfor();
            Console.WriteLine("Age: "+ student.GetAge());
            Console.ReadKey();
        }
    }
}