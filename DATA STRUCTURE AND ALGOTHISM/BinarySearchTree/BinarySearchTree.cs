using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BinarySearchTree
{
    internal class BinarySearchTree
    {
        private IntNode root;
        public IntNode Root
        {
            get { return root; }
            set { root = value; }
        }
        public BinarySearchTree()
        {
            root = null;
        }
        public bool Insert(int x)
        {
            if (root == null)
            {
                root = new IntNode(x);
                return true;
            }
            return root.InsertNode(x);
        }
        public void Input()
        {
            do
            {
                int x;
                Console.Write("Nhap gia tri (trung ket thuc): ");
                x = int.Parse(Console.ReadLine());
                if (Insert(x))
                {
                    Console.WriteLine("Da them vao cao");
                } else
                {
                    Console.WriteLine("Gia tri bi trung, ket thuc");
                    return;
                }
            } while (true);
        }
        public void PreOder()
        {
            if (root == null)
            {
                return;
            }
            root.LNR();
            Console.WriteLine();
        }
        public IntNode FindX(int x)
        {
            if (root == null)
            {
                return null;
            }
            return root.SearchX(x);
        }
        public IntNode FindMax()
        {
            if (root == null)
            {
                return null;
            }
            return root.GetMax();
        }
        public IntNode FindMin()
        {
            if (root == null)
            {
                return null;
            }
            return root.GetMin();
        }

        public int CountLeaf()
        {
            return root.Leaf();
        }
        // 5 2 8 1 7 3 9
        /*
         *         5
         *    2         8
         * 1     3    7    9 
         *                    
         */
        public void ListByLevel()
        {
            if (Root == null)
                return;

            Queue<IntNode> queue = new Queue<IntNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                Console.WriteLine("count = "+ queue.Count);
                {
                    int levelSize = queue.Count;

                    for (int i = 0; i < levelSize; i++)
                    {
                        IntNode node = queue.Dequeue();
                        Console.Write(node.Data + " ");

                        if (node.Left != null)
                            queue.Enqueue(node.Left);

                        if (node.Right != null)
                            queue.Enqueue(node.Right);
                    }

                    Console.WriteLine();
                }
            }
        }
        public void ListByLastLevel()
        {
            if (Root == null)
                return;

            Queue<IntNode> queue = new Queue<IntNode>();
            queue.Enqueue(Root);
            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                for (int i = 0; i < levelSize; i++)
                {
                    IntNode node = queue.Dequeue();

                    if (node.Left == null && node.Right == null)
                    {
                        Console.Write(node.Data + " ");
                    }

                    if (node.Left != null)
                        queue.Enqueue(node.Left);

                    if (node.Right != null)
                        queue.Enqueue(node.Right);
                }
            }
        }
        public bool Remove(int x)
        {
            if (root == null)
            {
                return false;
            }
            if (x == root.Data)
            {
                IntNode tmp = new IntNode(0);
                tmp.Left = root;
                bool kq = root.Remove(x, tmp);
                root = tmp.Left;
                return kq;
            }
            return root.Remove(x, null);
        }
    }
}
