using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Program
    {
        static void Input(Queue queue)
        {
            while (true)
            {
                Console.Write("Nhap gia tri >= 0: ");
                int x = int.Parse(Console.ReadLine());
                if (x < 0)
                {
                    return;
                }
                queue.Enqueue(x);
            }
        }
        static void Output(Queue queue)
        {
            int top;
            while (!queue.IsEmpty())
            {
                queue.DeQueue(out top);
                Console.WriteLine(top +" ");
            }
            Console.WriteLine();
        }
        static void TestQueue1()
        {
            int x;
            Queue queue = new Queue(5);
            Input(queue);
            queue.DeQueue(out x);
            queue.DeQueue(out x);
            queue.DeQueue(out x);
            queue.DeQueue(out x);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);

            Output(queue);



        }
        static void TestQueue2()
        {
            int top;
            Queue queue = new Queue(5);
            Input(queue);
            queue.DeQueue(out top);
            queue.DeQueue(out top);
            queue.Enqueue(6);
            queue.Enqueue(7);
            Output(queue);
        }
        static void Input(ListQueue queue)
        {
            int x;
            while (true)
            {
                Console.Write("Nhap gia tri >= 0: ");
                x = int.Parse(Console.ReadLine());
                if (x < 0)
                {
                    return;
                }
                queue.Enqueue(x);
            }
        }
        static void Output(ListQueue queue)
        {
            int top;
            while (!queue.IsEmpty())
            {
                queue.GetTop(out top);
                Console.Write(top +" ");
                queue.Dequeue(out top);
            }
        }
        static void TestListQueue()
        {
            ListQueue queue = new ListQueue();
            Input(queue);
            Output(queue);
        }
        static void Main(string[] args)
        {
            int y;
            TestQueue1();
            //TestQueue2();
            //TestListQueue();
            //Queue queue = new Queue(10);
            //queue.EnQueue(21); 
            //queue.EnQueue(24); 
            //queue.DeQueue(out y);
            //queue.EnQueue(28);
            //queue.EnQueue(32); 
            //queue.DeQueue(out y);
            //Console.WriteLine(y);
        }
    }
}
/*
 * 1 2 3 4 5
 *     3 4 5
 * 
 * 
 */
