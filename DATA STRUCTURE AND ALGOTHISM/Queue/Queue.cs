using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Queue
    {
        private int[] array;
        private int qMax, qFront, qRear;
        public int[] Array
        {
            get => array;
            set => array = value;
        }
        public int QMax {  
            get { return qMax; } 
            set { qMax = value; }
        }
        public int QFront
        {
            get { return qFront; }
            set { qFront = value; }
        }
        public int QRear
        {
            get { return qRear; }
            set { qRear = value; }
        }
        public Queue() { }
        public Queue(int max = 0)
        {
            array = new int[max];
            qMax = max;
            qFront = -1;
            qRear = -1;
        }
        public bool IsEmpty()
        {
            return qFront == -1 ? true : false;
        }
        public bool IsFull()
        {
            return (qRear + 1) % qMax  == qFront ? true : false;
        }
        public bool Enqueue(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full. Cannot enqueue.");
                return false;
            }

            if (IsEmpty())
            {
                qFront = 0;
            }

            qRear = (qRear + 1) % qMax;
            array[qRear] = item;
            return true;
        }
        public bool DeQueue(out int outItem)
        {
            outItem = 0;
            if (IsEmpty())
            {
                return false;
            } else if (qFront == qRear)
            {
                outItem = array[qFront];
                qFront = qRear = -1;
            } else
            {
                outItem = array[qFront];
                qFront = (qFront + 1) % qMax;
            }
            return true;
        }
        public bool Top(out int topItem)
        {
            if (IsEmpty())
            {
                topItem = -1;
                return false;
            }
            topItem = array[qFront];
            return true;
        }

    }
}
