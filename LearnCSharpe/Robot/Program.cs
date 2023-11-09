using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class Program
    {
        static void robot(out int x, out int y)
        {
            string[] locate = Console.ReadLine().Split(' ');
             x = int.Parse(locate[0]);
             y = int.Parse(locate[1]);
            string[] step = Console.ReadLine().Split();
            for (int i = 0; i < step.Length; i++)
            {
                switch (step[i])
                {
                    case "D": x += 1;
                        break;
                    case "B": y += 1;
                        break;
                    case "T": x -= 1;
                        break;
                    case "N": y -= 1;
                        break;
                }
            }
            Console.WriteLine($"Robot loacted: {x}, {y}");
        }
        static void Main(string[] args)
        {
            int x, y;
            robot(out x, out y);
        }
    }
}
//1 1
// T T T T T T