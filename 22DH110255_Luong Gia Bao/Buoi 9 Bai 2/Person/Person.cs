using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Person
    {
        //Attribute
        private string name;
        private int birthYear;
        private string address;
        //Constructor
        public Person() { }
        public Person(string name, int birthYear, string address)
        {
            this.name = name;
            this.birthYear = birthYear;
            this.address = address;
        }
        //Method
        public virtual void Input()
        {
            Console.Write("Nhap ten: ");
            name = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            birthYear = int.Parse(Console.ReadLine());
            Console.Write("Nhap dia chi: ");
            address = Console.ReadLine();
        }
        public override string ToString() 
        {
            return $"Person[ Name: {name}  Bitrh year: {birthYear}  Address: {address}]";
        }
    }
}
