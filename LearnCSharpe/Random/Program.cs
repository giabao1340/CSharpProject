using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Program
{
    static void Main(string[] args)
    {
        Random random = new System.Random();
        StreamWriter streamwriter = new StreamWriter("D:/output.txt");
        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            if (i == n-1)
            {
                streamwriter.Write(random.Next(minValue: 0, maxValue: 100));
            }
            else {
                streamwriter.Write(random.Next(minValue: 0, maxValue: 100) + " ");
            }
        }
        streamwriter.Close();
        Console.WriteLine("Done!");
    }
}
