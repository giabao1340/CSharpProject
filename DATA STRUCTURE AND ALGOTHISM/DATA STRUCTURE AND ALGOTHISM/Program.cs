using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DATA_STRUCTURE_AND_ALGOTHISM
{
    internal class Program
    {
        static void TestInterchangeSort(IntArray obj)
        {
            //Copy ojb sang objTam để sắp xếp
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.InterchangeSort();
            Console.WriteLine("\n>>Interchange Sort:");
            objTam.Xuat();
        }
        static void TestInsertionSort(IntArray obj)
        {
            //Copy ojb sang objTam để sắp xếp
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.InsertionSort();
            Console.WriteLine("\n>>Insertion Sort:");
            objTam.Xuat();
        }
        static void TestSelectionSort(IntArray obj)
        {
            //Copy ojb sang objTam để sắp xếp
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.SelectionSort();
            Console.WriteLine("\n>>Selection Sort:");
            objTam.Xuat();
        }
        static void TestBubleSort(IntArray obj)
        {
            //Copy ojb sang objTam để sắp xếp
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.BubbleSort2();
            Console.WriteLine("\n>>BubleSort Sort:");
            objTam.Xuat();
        }
        static void TestShellSort(IntArray obj)
        {
            //Copy ojb sang objTam để sắp xếp
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.ShellSort();
            Console.WriteLine("\n>>Shell Sort:");
            objTam.Xuat();
        }
        static void TestQuickSort(IntArray obj)
        {
            //Copy ojb sang objTam để sắp xếp
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.QuickSort(0, obj.N) ;
            Console.WriteLine("\n>>Quick Sort:");
            objTam.Xuat();
        }
        static void TestMergeSort(IntArray obj)
        {
            //Copy ojb sang objTam để sắp xếp
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.Sort();
            Console.WriteLine("\n>>Quick Sort:");
            objTam.Xuat();
        }

        static void Main(string[] args)
        {
            int[] a = {35, 33, 42, 10, 14, 19, 27, 44, 1};
            IntArray obj = new IntArray(a);
            TestInsertionSort(obj);
        }
    }
}
