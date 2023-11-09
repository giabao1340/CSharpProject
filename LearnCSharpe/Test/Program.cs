using System;
using System.Threading;

// Simple threading scenario:  Start a static method running
// on a second thread.
public class ThreadExample
{
    // The ThreadProc method is called when the thread starts.
    // It loops ten times, writing to the console and yielding
    // the rest of its time slice each time, and then ends.
    public static void ThreadProc()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("ThreadProc: {0}", i);
            // Yield the rest of the time slice.
            Thread.Sleep(0);
        }
    }

    public static void Main()
    {
        Console.Write("Nhap a: ");
        string a = Console.ReadLine();
        Console.Write("Nhap b: ");
        string b = Console.ReadLine();
        string[] str1 = a.Split(' ');
        string[] str2 = b.Split();
        int lenght;
        if (str1.Length > str2.Length)
        {
            lenght = str1.Length;
        } else
        {
            lenght = str2.Length;
        }
        for (int i = lenght;i < lenght ; i++)
        {

        }
    }
}