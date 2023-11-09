using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class IntNode
    {
        private int data;
        private IntNode left;
        private IntNode right;
        //properties
        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public IntNode Left
        {
            get { return left; }
            set { left = value; }
        }
        public IntNode Right
        {
            get { return right; }
            set { right = value; }
        }
        //Constructor
        public IntNode(int x = 0)
        {
            data = x;
            left = null;
            right = null;
        }
        public bool InsertNode(int x)
        {
            if (x == data)
            {
                return false;
            }
            else if (x < data)
            {
                if (left == null)
                {
                    left = new IntNode(x);
                } else
                {
                    return left.InsertNode(x);
                }
            } else
            {
                if (right == null)
                {
                    right = new IntNode(x);
                } else
                {
                    return right.InsertNode(x);
                }
            }
            return true;
        }
        public void NLR()
        {
            Console.Write(data + " ");
            if (left != null)
            {
                left.NLR();
            }
            if (right != null)
            {
                right.NLR();
            }
        }
        // 5 2 8 1 7 3 9
        /*
         *         5
         *    2         8
         * 1     3    7    9 
         *                    
         */

        public int Leaf()
        {
            if (this == null)
                return 0;

            if (this.Left == null && this.Right == null)
                return 1;

            int leftCount = left.Leaf();
            int rightCount = right.Leaf();

            return leftCount + rightCount;
        }
        public void LNR()
        {
            if (left != null)
            {
                left.LNR();
            }
            Console.Write(data + " ");
            if (right != null)
            {
                right.LNR();
            }
        }
        public void LRN()
        {
            if (left != null)
            {
                left.LRN();
            }
            if (right != null)
            {
                right.LRN();
            }
            Console.Write(data +" ");
        }
        public IntNode SearchX(int x)
        {
            if (x == data)
            {
                return this;
            }
            else if (x < data)
            {
                if (left == null)
                {
                    return null;
                }
                return left.SearchX(x);
            } else
            {
                if (right == null)
                {
                    return null;
                }
                return right.SearchX(x);
            }
        }
        public IntNode GetMax()
        {
            if (right == null)
            {
                return this;
            }
            return right.GetMax();
        }
        public IntNode GetMin()
        {
            if (left == null)
            {
                return this;
            }
            return left.GetMin();
        }
        public int MinValue()
        {
            if (left == null)
            {
                return data;
            }
            return left.MinValue();
        }
        public bool Remove(int x, IntNode parent)
        {
            if (x < this.data)
            {
                if (left != null)
                {
                    return left.Remove(x, this);
                } else
                {
                    return false;
                }
            } else if(x > this.data)
            {
                if (right != null)
                {
                    return right.Remove(x, this);
                } else
                {
                    return false;
                }
            } else
            {
                if (left != null && right != null)
                {
                    this.Data = right.MinValue();
                    right.Remove(this.data, this);
                } else if(parent.left == this)
                {
                    parent.left = (left != null) ? left : right;
                }
                else if (parent.right == this)
                {
                    parent.right = (left != null) ? left : right;
                }
            }
            return true;
        }
    }
}