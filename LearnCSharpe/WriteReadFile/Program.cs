using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteReadFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Delete("D:/myFile.txt");
            Console.OutputEncoding = Encoding.UTF8;
            StreamWriter myFile = File.AppendText("D:/myFile.txt");
            myFile.WriteLine("1 2 3 4");
            myFile.Close();

            StreamReader streamReader = new StreamReader("D:/myFile.txt");
            string a = streamReader.ReadLine();
            Console.WriteLine(a);
        }
    }
}
