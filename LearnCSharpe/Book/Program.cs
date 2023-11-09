using ConsoleApp4;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author a = new Author("Luong Gia Bao", "luonggiabao060904@gmail.com", 'm');
            book b = new book("Hello world", a, 10, 3);
            Console.WriteLine(a.toString());
            Console.WriteLine(b.toString());
            a.setEmail("luonggiabao1340@gmail.com");
            b.setPrice(0);
            Console.WriteLine(a.toString());
            Console.WriteLine(b.toString());


        }
    }
}
