using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Program
    {
        static void TestInput()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Input();
            Console.WriteLine("Cac gia tri trong cay: ");
            binarySearchTree.PreOder();
        }
        static void TestFindX()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Input();
            Console.WriteLine("Cac gia tri trong cay: ");
            binarySearchTree.PreOder();
            Console.Write("Nhap gia tri can tim: ");
            int x = int.Parse(Console.ReadLine());
            IntNode node = binarySearchTree.FindX(x);
            Console.WriteLine(node.Data);
        }
        static void TestGetMin()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Input();
            Console.WriteLine("Cac gia tri trong cay: ");
            binarySearchTree.PreOder();
            IntNode node = binarySearchTree.FindMin();
            Console.WriteLine("Min: " + node.Data);
        }
        static void TestGetMax()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Input();
            Console.WriteLine("Cac gia tri trong cay: ");
            binarySearchTree.PreOder();
            IntNode node = binarySearchTree.FindMax();
            Console.WriteLine("Max: "+ node.Data);
        }
        static void TestListByLevel()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Input();
            Console.WriteLine("Cac gia tri trong cay: ");
            binarySearchTree.ListByLevel();
        }
        static void TestListLastLevel()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Input();
            Console.WriteLine("Cac gia tri trong cay: ");
            binarySearchTree.ListByLastLevel();
        }
        static void TestRemove()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Input();
            Console.WriteLine("Cac gia tri trong cay: ");
            binarySearchTree.PreOder();
            Console.Write("Nhap so can xoa: ");
            int x = int.Parse(Console.ReadLine());
            binarySearchTree.Remove(x);
            Console.WriteLine("Cay sau khi xoa: ");
            binarySearchTree.PreOder();
        }
        static void TestCountLeaf()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Input();
            Console.WriteLine("Cac gia tri trong cay: ");
            binarySearchTree.PreOder();
            int leaf = binarySearchTree.CountLeaf();
            Console.WriteLine("So node la tong cay: " +leaf);
        }
        static void Main(string[] args)
        {
            //TestInput();
            TestCountLeaf();
            //TestFindX();
            //TestGetMax();
            //TestGetMin();
            //TestRemove();
            //TestListByLevel
            //TestListLastLevel();
        }
    }
}
