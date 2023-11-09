using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Date date = new Date();
            //date.setDay(0);
            //date.setMonth(0);
            //date.setYear(0);
            Date time = new Date(15, 6, 2007);
            Console.WriteLine(time.toString());
            //Console.WriteLine(time.toString());
            time.setDay(5);
            Console.WriteLine(time.toString()); ;
        }
    }
}
