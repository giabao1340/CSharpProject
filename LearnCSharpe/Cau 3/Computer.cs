using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau_3
{
    internal class Computer
    {
        //Attribute
        protected string cpu;
        protected int ram;
        protected int storage;
        protected double price;
        //Property
        public double Price
        {
            get{return price;}
            set
            {
                if (value > 0)
                {
                    price = value;
                } else
                {
                    Console.WriteLine("Invalid price");
                }
            }
        }
        //Constructor
        public Computer() { }
        public Computer(string cpu, int ram, int storage, double price)
        {
            this.cpu = cpu;
            this.ram = ram;
            this.storage = storage;
            this.price = price;
        }
        //Method
        public virtual void Input()
        {
            Console.Write("CPU: ");
            cpu = Console.ReadLine();
            Console.Write("Ram: ");
            ram = int.Parse(Console.ReadLine());
            Console.Write("Storage: ");
            storage = int.Parse(Console.ReadLine());
            Console.Write("Price: ");
            price = int.Parse(Console.ReadLine());
        }
        public string toString()
        {
            return $"CPU: {cpu}, Ram: {ram}, Storage: {storage}, Price: {Price}";
        }
    }
    }

