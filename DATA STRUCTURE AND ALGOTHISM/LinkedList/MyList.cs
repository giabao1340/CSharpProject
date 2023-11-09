using DSLKDon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    internal class MyList
    {
        private IntNode first;
        private IntNode last;
        private int count;
        public IntNode First
        {
            get { return first; }
            set { first = value; }
        }
        public IntNode Last
        {
            get { return last; }
            set { last = value; }

        }
        public int Count
        {
            get
            {
                IntNode p = first;
                count = -1;
                while (p != null)
                {
                    count++;
                    p = p.Next;
                }
                return count;
            }
        }
        public MyList()
        {
            first = null;
            last = null;
        }
        public bool IsEmpty()
        {
            return first == null;
        }
        public void AddFirst(IntNode newNode)
        {
            if (IsEmpty())
            {
                first = last = newNode;
            }
            else
            {
                newNode.Next = first;
                first = newNode;
            }
        }
        public void AddLast(IntNode newNode)
        {
            newNode.Next = null;
            if (IsEmpty())
            {
                first = last = newNode;
            }
            else
            {
                IntNode p = first;
                while (p.Next != null)
                {
                    p = p.Next;
                }
                p.Next = newNode;
                last = p.Next;
            }
        }
        public void Input()
        {
            int x;
            do
            {
                Console.Write("Gia tri( 0 ket thuc): ");
                x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    return;
                }
                IntNode newNode = new IntNode(x);
                AddLast(newNode);

            } while (true);
        }
        public void ShowList()
        {
            IntNode p = first;
            while (p != null)
            {
                Console.Write($"{p.Data} ->");
                p = p.Next;
            }
            Console.WriteLine("null");
        }
        public IntNode Search(int x)
        {
            IntNode node = first;
            while (node != null && node.Data != x)
            {
                node = node.Next;
            }
            if (node != null)
            {
                return node;
            }
            return null;
        }
        public IntNode GetMax()
        {
            IntNode p = first;
            IntNode maxNode = p.Next;
            while (p != null)
            {
                if (p.Data > maxNode.Data)
                {
                    maxNode = p;
                }
                p = p.Next;
            }
            return maxNode;
        }
        public IntNode GetMin()
        {
            IntNode p = first;
            IntNode minNode = p.Next;
            while (p != null)
            {
                if (p.Data < minNode.Data)
                {
                    minNode = p;
                }
                p = p.Next;
            }
            return minNode;
        }
        public LinkedList<int> GetEvenList()
        {
            IntNode p = first;
            LinkedList<int> list = new LinkedList<int>();
            while (p != null)
            {
                if (p.Data % 2 == 0)
                {
                    list.AddFirst(p.Data);
                }
                p = p.Next;
            }
            return list;
        }
        public LinkedList<int> GetOddList()
        {
            IntNode p = first;
            LinkedList<int> list = new LinkedList<int>();
            while (p != null)
            {
                if (p.Data % 2 != 0)
                {
                    list.AddFirst(p.Data);
                }
                p = p.Next;
            }
            return list;
        }
        public IntNode FindPrevNode(IntNode p)
        {
            IntNode prevNode  = first;
            while (prevNode != null)
            {
                if (prevNode.Next == p)
                {
                    break;
                }
                prevNode = prevNode.Next;
            }
            return prevNode;
        }
        public void InsertAfter(IntNode p, IntNode newNode)
        {
            if (p == last)
            {
                AddLast(newNode);
            }
            else
            {
                newNode.Next = p.Next;
                p.Next = newNode;
            }
        }
        public void SwapNode(IntNode p, IntNode newNode )
        {
            int temp = p.Data;
            p.Data = newNode.Data;
            newNode.Data = temp;
        }
        public void InsertBefore(IntNode p, IntNode newNode)
        {
            if (p == first)
            {
                AddFirst(newNode);
            }
            else
            {
                InsertAfter(p, newNode);
                SwapNode(p, newNode);
            }
        }
        public void RemoveAt(int i)
        {
            int count = 0;
            IntNode p = first;
            while (p != null)
            {
                if (count == i)
                {
                    break;
                }
                count++;
                p = p.Next;
            }
            IntNode prev = FindPrevNode(p);
            prev.Next = p.Next;

        }
        public void RemoveX(IntNode p)
        {
            IntNode prev = FindPrevNode(p);
            if (p == first)
            {
                first = p.Next;
            }
            else if (p == last)
            {
                last = prev;
                last.Next = null;
            }
            else
            {
                prev.Next = p.Next;
            }

        }
        public void RemoveAllX(int x)
        {
            IntNode p = first; 
            while (p != null)
            {
                if (p.Data == x)
                {
                    RemoveX(p);
                }
                p = p.Next;
            }
        }
        public void RemoveFirst()
        {
            first = first.Next;
        }
        public void InsertAt(int x, int i)
        {
            int count = 0;
            IntNode newNode = new IntNode(x);
            IntNode p = first;
            while (p != null)
            {
                if (count == i)
                {
                    break;
                }
                count++;
                p = p.Next;
            }
            InsertBefore(p, newNode);
        }
        public void InsertXAfterMin()
        {
            Console.Write("Nhap x: ");
            int x = int.Parse(Console.ReadLine());
            IntNode newNode = new IntNode(x);
            Console.WriteLine($"Min = {GetMin().Data}");
            Console.WriteLine($"Insert {x} After Min: ");
            InsertAfter(GetMin(), newNode);
        }
        public void InsertXAfterY()
        {
            Console.Write("Nhap X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap Y : ");
            int y = int.Parse(Console.ReadLine());
            IntNode newNode = new IntNode(x);
            IntNode p = Search(y);
            if (p == null)
            {
                Console.WriteLine("khong tim thay node can chen");
            }
            else
            {
                Console.WriteLine($"Chen node co data bang {x} sau node co data bang {y}");
                InsertAfter(p, newNode);
                ShowList();
            }
        }
        public void InsertXBeforeMax()
        {
            Console.Write("Nhap x: ");
            int x = int.Parse(Console.ReadLine());
            IntNode newNode = new IntNode(x);
            Console.WriteLine($"Max = {GetMax().Data}");
            Console.WriteLine($"Insert {x} Before Max: ");
            InsertBefore(GetMax(), newNode);
        }
        public void InsertXBeforeY()
        {
            Console.Write("Nhap X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap Y : ");
            int y = int.Parse(Console.ReadLine());
            IntNode newNode = new IntNode(x);
            IntNode p = Search(y);
            if (p == null)
            {
                Console.WriteLine("khong tim thay node can chen");
            }
            else
            {
                Console.WriteLine($"Chen node co data bang {x} sau node co data bang {y}");
                InsertBefore(p, newNode);
                ShowList();
            }
        }
        public void RShiftRight()
        {
            IntNode q = last;
            RemoveX(q);
            AddFirst(q);

        }
        public void InterchangeSort()
        {
            IntNode i = first;
            bool swaped;
            while (i != null)
            {
                IntNode j = i.Next;
                swaped = false;
                while (j != null)
                {
                    if (i.Data > j.Data)
                    {
                        SwapNode(i, j);
                        swaped = true;
                    }
                    j = j.Next;
                }
                i = i.Next;
                if (!swaped)
                {
                    break;
                }
            }
        }
        public void SelectionSort()
        {
            IntNode minIndex;
            IntNode i = first;
            bool swap;
            while (i != null)
            {
                minIndex = i;
                IntNode j = i.Next;
                swap = false;
                while (j != null)
                {
                    if (j.Data < minIndex.Data)
                    {
                        minIndex = j;
                        swap = true;
                    }
                    j = j.Next;
                }
                if (!swap)
                {
                    break;
                }
                SwapNode(i, minIndex);
                i = i.Next;
            }
        }
    }
}
