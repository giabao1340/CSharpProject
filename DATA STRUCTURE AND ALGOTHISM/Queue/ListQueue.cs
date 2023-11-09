using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class ListQueue
    {
        Linkedlist queue;
        Node front;
        Node rear;
        public ListQueue()
        {
            queue = new Linkedlist();
        }
        public bool IsEmpty() {  return queue.IsEmpty(); }
        public bool Enqueue(int x)
        {
            Node newNode = new Node(x);
            queue.AddLast(newNode);
            return true;
        }
        public bool Dequeue(out int outItem)
        {
            outItem = 0;
            if (IsEmpty())
            {
                return false;
            }
            queue.RemoveFirst();
            return true;
        }
        public bool GetTop(out int outItem)
        {
            outItem = 0;
            if (IsEmpty())
            {
                return false;
            }
            outItem = queue.First.Data;
            return true;
        }

    }
}
