using System;
using System.Collections.Generic;

class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

class BinarySearchTree
{
    public Node Root;

    public BinarySearchTree()
    {
        Root = null;
    }

    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    private Node InsertRec(Node root, int data)
    {
        if (root == null)
        {
            root = new Node(data);
        }
        else if (data < root.Data)
        {
            root.Left = InsertRec(root.Left, data);
        }
        else if (data > root.Data)
        {
            root.Right = InsertRec(root.Right, data);
        }

        return root;
    }

    public void ListByLastLevel()
    {
        if (Root == null)
            return;

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;

            for (int i = 0; i < levelSize; i++)
            {
                Node node = queue.Dequeue();

                // If this is the last level, print the element
                if (i == levelSize - 1)
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
}

class Program
{
    static void Main(string[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(15);
        bst.Insert(3);
        bst.Insert(7);
        bst.Insert(12);
        bst.Insert(18);

        Console.WriteLine("Elements in the last level of the binary search tree:");
        bst.ListByLastLevel();
    }
}
