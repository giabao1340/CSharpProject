using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intstack
{
    internal class Program
    {
        static void Input(ArrayStack arrayStack)
        {
            int x;
            while (true)
            {
                Console.Write("Nhap gia tri >= 0: ");
                x = int.Parse(Console.ReadLine());
                if (x < 0)
                {
                    break;
                }
                arrayStack.Push(x);
            }
        }
        static void Output(ArrayStack arrayStack)
        {
            int outItem;
            while (!arrayStack.IsEmpty())
            {
                arrayStack.GetTop(out outItem);
                Console.Write($"{outItem} ");
                arrayStack.Pop(out outItem);
            }
        }
        static void TestArray()
        {
            ArrayStack arrayStack = new ArrayStack(1000);
            Input(arrayStack);
            Console.WriteLine("Cac gia tri trong stack");
            Output(arrayStack);
        }
        static void Input(ListStack ls)
        {
            int x;
            do
            {
                Console.Write("Nhap gia tri >= 0: ");
                x = int.Parse(Console.ReadLine());
                if (x < 0)
                {
                    return;
                }
                Node node = new Node(x);
                ls.Push(node);

            } while (x >= 0);
        }
        static void Output(ListStack ls)
        {
            int outItem;
            while (!ls.Empty())
            {
                ls.Pop(out outItem);

                Console.Write(outItem + " ");
            }
        }
        static void TestListStack()
        {
            ListStack arrStack = new ListStack();
            Input(arrStack);
            Console.WriteLine("Cac gia tri trong Stack:");
            Output(arrStack);

        }

        static void Main(string[] args)
        {
            //TestArray();
            TestListStack();
        }

    }
}
