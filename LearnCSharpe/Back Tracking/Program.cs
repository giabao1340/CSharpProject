using System;

namespace ConsoleApp12
{
    class Program
    {
        static int n, k;
        static int[] x;
        static bool[] states;
        static bool[] cot, dcc, dcp;
        static int count;
        static void Try(int i)
        {
            if (i > k)
            {
                xuatNghiem();
            }
            else
            {
                for (int j = 1; j <= n; j++)
                {
                    x[i] = j;
                    Try(i + 1);
                }
            }
        }
        static void Try2(int i)
        {
            if (i > k)
            {
                xuatNghiem();
            }
            else
            {
                for (int j = 1; j <= n; j++)
                {
                    if (states[j] == false)
                    {
                        x[i] = j;
                        states[j] = true;
                        Try2(i + 1);
                        states[j] = false;
                    }
                }
            }
        }
        static void Try3(int i)
        {
            if (i > k)
            {
                xuatNghiem();
            }
            else
            {
                for (int j = x[i - 1] + 1; j <= n; j++)
                {
                    x[i] = j;
                    Try3(i + 1);
                }
            }
        }
        static void XuatNghiem()
        {
            Console.Write($"Solution {++count}: ");
            for (int i = 0; i < 7; i++)
            {
                if (i == 6)
                {
                    Console.WriteLine(x[6] + 1);
                    break;
                }
                Console.Write(x[i] + 1 + ", ");

            }
            Console.WriteLine();
        }


        static void xuatNghiem()
        {
            Console.Write("{");

            for (int i = 1; i <= k; i++)
            {
                if (i == k)
                {
                    Console.WriteLine(x[k] +"}");
                    break;
                }
                Console.Write(x[i] + ", ");
            }
        }



        static void chess(int i)
        {
            if (i > 7)
            {
                XuatNghiem();
            }
            else
            {
                for (int j = 0; j <= 7; j++)
                {
                    if (!cot[j] && !dcc[i - j + 7] && !dcp[i + j])
                    {
                        x[i] = j;
                        cot[j] = true;
                        dcc[i - j + 7] = true;
                        dcp[i + j] = true;
                        chess(i + 1);
                        cot[j] = false;
                        dcc[i - j + 7] = false;
                        dcp[i + j] = false;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap lan luot k, n");
            string[] numbs = Console.ReadLine().Split();
            k = int.Parse(numbs[0]);
            n = int.Parse(numbs[1]);
            x = new int[8];
            //cot = new bool[8];
            //dcc = new bool[15];
            //dcp = new bool[15];
            //count = 0;
            states = new bool[n + 1];
            //           Try(1);
            //Try2(1);
            Try3(1);
            chess(0);
        }
    }
}
