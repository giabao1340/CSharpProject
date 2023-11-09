using Intstack;
using LinkedList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class ListStack
    {
        private Linkedlist ls;
        public ListStack()
        {
            ls = new Linkedlist();
        }

        public bool Empty() => ls.IsEmpty();
        public void Push(Node newNode)
        {
            ls.AddFirst(newNode);
        }
        public bool Pop(out int outItem)
        {
            outItem = 0;
            if (ls.IsEmpty()) return false;
            outItem = GetTop();
            ls.RemoveFirst();
            return true;
        }
        public int GetTop()
        {
            int top = ls.First.Data;
            return top;
        }
    }
}
