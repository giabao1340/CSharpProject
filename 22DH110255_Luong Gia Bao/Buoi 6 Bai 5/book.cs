
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class book
    {
        //Attribute
        private string name;
        private Author author;
        private double price;
        private int qty;
        //properties
        public string Name 
        { 
            get { return name; } 
            set { name = value; }
        }
        public Author Author
        {
            get { return author; }
            set { author = value; }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Price can not be less than or equal 0");
                        value = double.Parse(Console.ReadLine());
                    } while (value <= 0);
                    price = value;
                }
            }
        }
        public int Qty
        {
            get { return qty; }
            set
            {
                if (value > 0)
                {
                    qty = value;
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Quantity can not be less than or equal 0");
                        value = int.Parse(Console.ReadLine());
                    } while (value <= 0);
                    qty = value;
                }
            }
        }
        //Constructor
        public book(string name, Author author, double price)
        {
            this.name = name;
            this.author = author;
            Price = price;
        }
        public book() { }
        public book(string name, Author author, double price, int qty)
        {
            this.name = name;
            this.author = author;
            Price = price;
            Qty = qty;
        }
        //Method
        public string getName()
        {
            return name;
        }
        public Author getAuthor()
        {
            return author;
        }
        public double getPrice()
        {
            return price*qty;
        }
        public void setPrice(double price)
        {
            Price = price;
        }
        public int getQty()
        {
            return qty;
        }
        public void setQty(int qty)
        {
            Qty = qty;
        }
        public string toString()
        {
            string nameAuthor = author.getName();

            return $"Book[name = {getName()}, Author = {nameAuthor}, gender = {author.getGender()}, price = {Price}$, qty = {Qty} ]";
        }
    }
}
