using DSLKDon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LinkedList
{
    internal class Program
    {
        static void TestInput()
        {
            MyList list = new MyList();
            list.Input();
            Console.WriteLine("DSLK so nguyen: ");
            list.ShowList();
        }
        static void TestAddFirst()
        {
            MyList list = new MyList();
            list.Input();
            list.ShowList();
            Console.WriteLine("Add first: ");
            IntNode newNode = new IntNode();
            Console.WriteLine("Nhap gia tri can them vao dau danh sach: ");
            newNode.Data = int.Parse(Console.ReadLine());
            list.AddFirst(newNode);
            list.ShowList();
        }
        static void TestAddLast()
        {
            MyList list = new MyList();
            list.Input();
            list.ShowList();
            IntNode newNode = new IntNode();
            Console.WriteLine("Nhap gia tri can them vao cuoi danh sach: ");
            newNode.Data = int.Parse(Console.ReadLine());
            list.AddLast(newNode);
            list.ShowList();
        }
        static void TestSearch()
        {
            MyList list = new MyList();
            list.Input();
            list.ShowList();
            Console.WriteLine("Nhap so can tim: ");
            int x = int.Parse(Console.ReadLine());
            if (list.Search(x) == null)
            {
                Console.WriteLine("Khong tim thay x");
            }
            else
            {
                Console.WriteLine($"node {list.Search(x).Data} = x");
            }
        }
        static void TestGetMax()
        {
            MyList list = new MyList();
            list.Input();
            list.ShowList();
            Console.WriteLine($"Max node = {list.GetMax().Data}");
        }
        static void TestGetMin()
        {
            MyList list = new MyList();
            list.Input();
            list.ShowList();
            Console.WriteLine($"Min node = {list.GetMin().Data}");
        }
        static void TestGetEvenList()
        {
            MyList list = new MyList();
            list.Input();
            list.ShowList();
            Console.Write("List cac phan tu chan: ");
            LinkedList<int> newList = list.GetEvenList();
            foreach (var item in newList)
            {
                Console.Write(item + " ");
            }
        }
        static void TestGetOddList()
        {
            MyList list = new MyList();
            list.Input();
            list.ShowList();
            Console.Write("List cac phan tu le: ");
            LinkedList<int> newList = list.GetOddList();
            foreach (var item in newList)
            {
                Console.Write(item + " ");
            }
        }
        static void TestFindPrev()
        {
            Console.Write("Nhap data cua node can tim x: ");
            int x = int.Parse(Console.ReadLine());
            MyList list = new MyList();
            list.Input();
            list.ShowList();
            IntNode p = list.Search(x);
            IntNode q = list.FindPrevNode(p);
            if (p == null)
            {
                Console.WriteLine("khong tim thay node trong danh sach");
            }
            else
            {
                Console.WriteLine($"Data cua node phia truoc: {q.Data}");
            }
        }
        static void TestInsertAfter()
        {
            Console.Write("Nhap data cua node can chen phia sau (p): ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap node can chen (newNode): ");
            IntNode newNode = new IntNode();
            newNode.Data = int.Parse(Console.ReadLine());
            MyList list = new MyList();
            list.Input();
            list.ShowList();
            IntNode p = list.Search(x);
            if (p == null)
            {
                Console.WriteLine("khong tim thay node can chen");
            }
            else
            {
                list.InsertAfter(p, newNode);
                Console.WriteLine($"Chen node co data bang {newNode.Data} sau node co data bang {p.Data}");
                list.ShowList();
            }
        }
        static void TestInsertBefore()
        {
            Console.Write("Nhap data cua node can chen phia truoc(p): ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap node can chen (newNode): ");
            IntNode newNode = new IntNode();
            newNode.Data = int.Parse(Console.ReadLine());
            MyList list = new MyList();
            list.Input();
            list.ShowList();
            IntNode p = list.Search(x);
            if (p == null)
            {
                Console.WriteLine("khong tim thay node can chen");
            }
            else
            {
                Console.WriteLine($"Chen node co data bang {newNode.Data} truoc node co data bang {p.Data}");
                list.InsertBefore(p, newNode);
                list.ShowList();
            }
        }
        static void TestRemoveX()
        {
            Console.Write("Nhap data cua node can tim x: ");
            int x = int.Parse(Console.ReadLine());
            MyList list = new MyList();
            list.Input();
            list.ShowList();
            IntNode p = list.Search(x);
            if (p == null)
            {
                Console.WriteLine("khong tim thay node trong danh sach");
            }
            else
            {
                list.RemoveX(p);
                list.ShowList();
            }
        }
        static void TestRemoveAll()
        {
            Console.Write("Nhap x: ");
            int x = int.Parse(Console.ReadLine());

            MyList list = new MyList();
            list.Input(); list.ShowList();
            list.RemoveAllX(x);
            Console.WriteLine("List sau khi xoa: ");
            list.ShowList();

        }
        static void TestRemoveAt()
        {
            Console.Write("Nhap data cua node can tim x: ");
            int x = int.Parse(Console.ReadLine());
            MyList list = new MyList();
            list.Input();
            list.ShowList();
            Console.WriteLine($"Mang sau khi xoa tai vi tri {x}");
            list.RemoveAt(x); 
            list.ShowList();
        }
        static void TestInsertAt()
        {
            Console.Write("Nhap gia tri cua can chen: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vi tri cua node can chen: ");
            int i = int.Parse(Console.ReadLine());
            MyList list = new MyList();
            list.Input();
            list.ShowList();
            Console.WriteLine("List sau khi chen: ");
            list.InsertAt(x, i);
            list.ShowList();
        }
        static void TestInsertXAfterMIn()
        {
            MyList list = new MyList();
            list.Input();
            list.ShowList();
            list.InsertXAfterMin();
            list.ShowList();
        }
        static void TestInsertXAfterY()
        {
            MyList myList = new MyList();
            myList.Input();
            myList.ShowList();
            myList.InsertXAfterY();
        }
        static void TestInsertXBeforeMax()
        {
            MyList list = new MyList();
            list.Input();
            list.ShowList();
            list.InsertXBeforeMax();
            list.ShowList();
        }
        static void TestInsertXBeforeY()
        {
            MyList myList = new MyList();
            myList.Input();
            myList.ShowList();
            myList.InsertXBeforeY();
        }
        static void TestRShiftRight()
        {
            MyList myList = new MyList();
            myList.Input();
            myList.ShowList();
            myList.RShiftRight();
            myList.ShowList();

        }
        static void TestInterChangesort()
        {
            MyList myList = new MyList();
            myList.Input();
            myList.ShowList();
            Console.WriteLine("List sau khi sap xep: ");
            myList.InterchangeSort();
            myList.ShowList();
        }
        static void TestSelectionSort()
        {
            MyList myList = new MyList();
            myList.Input();
            myList.ShowList();
            Console.WriteLine("List sau khi sap xep: ");
            myList.SelectionSort();
            myList.ShowList();
        }

        static void InputListStack(ListStack ls)
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
                IntNode node = new IntNode(x);
                ls.Push(node);

            } while (x >= 0);
        }
        static void ShowListStack(ListStack ls)
        {
            while (!ls.IsEmpty())
            {
                int top = ls.GetTop();
                Console.Write(top +" ");
                ls.Pop();
            }
        }
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("-----------------------------------------MENU----------------------------------------");
            //Console.WriteLine("1.\tRemoveAt(int i): Xóa node tại vị trí thứ i (thứ tự node được tính bắt đầu từ 0)\r\n2.\tRemoveX(): Xóa node có giá trị x\r\n3.\tInsertAt(int x, int i): Chèn x vào danh sách tại vị trí thứ i (thứ tự node được tính bắt đầu từ 0) \r\n4.\tInsertXAfterMin(): Chèn x vào sau node có giá trị nhỏ nhất\r\n5.\tInsertXAfterY(): Chèn x vào sau node có giá trị y\r\n6.\tInsertXBeforeMax(): Chèn x vào trước node có giá trị lớn nhất\r\n7.\tInsertXBeforeY(): Chèn x vào trước node có giá trị y\r\n8.\tRShiftRight(): Trả về danh sách sau khi dịch phải xoay vòng (Các node dịch về phải và node cuối cùng trở thành node đầu tiên của danh sách)\r\n9.\tInterchangeSort(): Sắp xếp danh sách theo thứ tự các giá trị tăng dần dùng phương pháp đổi chổ trực tiếp (Interchange sort).\r\n10.\tSelectionSort(): Sắp xếp danh sách theo thứ tự giảm dần các giá trị trong danh sách bằng phương pháp chọn trực tiếp (Selection sort).\r\n");
            //int x;
            //do
            //{
            //    Console.Write("Nhập số tương ứng: ");
            //    x = int.Parse(Console.ReadLine());

            //} while (x < 1 || x > 10 );

            //switch (x)
            //{
            //    case 1: TestRemoveAt(); break;
            //    case 2: TestRemoveX(); break;
            //    case 3: TestInsertAt(); break;
            //    case 4: TestInsertXAfterMIn(); break;
            //    case 5: TestInsertXAfterY(); break;
            //    case 6: TestInsertXBeforeMax(); break;
            //    case 7: TestInsertXBeforeY(); break;
            //    case 8: TestRShiftRight(); break;
            //    case 9: TestInterChangesort(); break;
            //    case 10: TestSelectionSort(); break;
            //    default:
            //        Console.WriteLine("Lỗi đầu vào");
            //        break;
            //}

            ListStack listStack = new ListStack();
            InputListStack(listStack);
            ShowListStack(listStack);

        }
    }
}

