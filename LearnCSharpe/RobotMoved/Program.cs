using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class Program
    {
        static void robot(string s, ref int x, ref int y)
        {

                switch (s)
                {
                    case "D":
                        x += 1;
                        break;
                    case "B":
                        y += 1;
                        break;
                    case "T":
                        x -= 1;
                        break;
                    case "N":
                        y -= 1;
                        break;
                }
        }
        static void moved(out int x, out int y)
        {
            string dir = "";
            string[] locate = Console.ReadLine().Split(' ');
            x = int.Parse(locate[0]);
            y = int.Parse(locate[1]);
            string[] move = Console.ReadLine().Split();
            string[] step = new string[4] { "D", "N", "T", "B" };
                                        //   0    1    2    3

            int index = 0;
            for (int i = 0; i < move.Length; i++)
            {
                switch (move[i])
                {
                    case "F":
                        if (index > 3)
                        {
                            index -= 4;
                        }
                        dir = step[index];
                        break;
                    case "B":
                        index += 2;
                        if (index > 3)
                        {
                            index -= 4;
                        }
                        dir = step[index];
                        break;
                    case "L":
                        index += 3;
                        if (index > 3)
                        {
                            index -= 4;
                        }
                        dir = step[index];
                        break;
                    case "R":
                        index += 1;
                        if (index > 3)
                        {
                            index -= 4;
                        }
                        dir = step[index];
                        break;
                }
                robot(dir, ref x, ref y);
            }
            Console.WriteLine($"Robot loacted: {x}, {y}");
        }
        static void Main(string[] args)
        {
            //int x, y;
            //moved(out x, out y);
            double db = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{db:0.00}");
        }
    }
}
//1 1
//F F L F L R R F F
