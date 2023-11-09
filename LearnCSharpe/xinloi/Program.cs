using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class TestCsharp
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            StreamWriter myFile = File.AppendText("D:\\file.txt");
            for (int i = 100; i <= 200; i++)
            {
                myFile.WriteLine($"{i}. Cho  tui Xin lỗi");
            }
            Console.WriteLine("Done");
            myFile.Close();

            Console.ReadKey();
        }
    }
}