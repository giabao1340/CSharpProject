using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_STRUCTURE_AND_ALGOTHISM
{
    public class IntArray
    {
        //Field
        private int[] arr;
        private int n;
        //Properties
        public int N { get => n; set => n = (value >= 0 && value <= 1000000 ? value : 0); }
        public int[] Arr { get => arr; set => arr = value; }
        public IntArray()
        {
            n = 0;
            arr = new int[n];
        }
        public IntArray(int k)
        {
            n = k;
            arr = new int[n];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 201);
            }
        }
        public IntArray(int[] a)
        {
            n = a.Length;
            arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = a[i];
            }
        }
        public IntArray(int[] a, int n)
        {
            this.n = n;
            arr = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                arr[i] = a[i];
            }
        }
        //9 0 1 2 3 4
        public IntArray(IntArray obj)
        {
            n = obj.n;
            this.arr = obj.arr;
        }
        public void Nhap()
        {
            Console.Write("Nhap so phan tu: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}]= ", (i + 1));
            }
        }
        public void Xuat()
        {
            Console.WriteLine("Cac phan tu cua mang: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}]= {1}", (i), arr[i]);
            }
            Console.WriteLine();
        }
        public int LinearSearch(int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
        public int BinarySearch(int x, int low, int hight)
        {
            while (low <= hight)
            {
                int mid = low + (hight - low) / 2;
                if (Arr[mid] == x)
                {
                    return mid;
                }
                if (Arr[mid] < x)
                {
                    low = mid + 1;
                }
                else
                {
                    hight = mid - 1;
                }
            }
            return -1;
        }
        public void HoanVi(ref int a, ref int b)
        {
            int tam = a;
            a = b;
            b = tam;
        }
        public void InterchangeSort()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        HoanVi(ref arr[i], ref arr[j]);
                    }
                }
            }
        }
        public void InsertionSort()
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && key < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j+1] = key;
            }
        }
        public void BubbleSort()
        {
            int i, j, temp;
            bool swapped;
            int n = arr.Length - 1;
            for (i = 0; i < n; i++)
            {
                swapped = false;
                for (j = 0; j < n - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
            }
        }
        public void BubbleSort2()
        {
            int i, j, temp;
            bool swapped;
            int n = arr.Length-1;
            for (i = 0; i <= n; i++)
            {
                swapped = false;
                for (j = n-1; j >= 0; j--)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
            }
        }
        public void SelectionSort()
        {
            int minIdx;
            bool swaped;
            for (int i = 0; i < n - 1; i++)
            {
                swaped = false;
                minIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIdx])
                    {
                        minIdx = j;
                        swaped = true;
                    }
                }
                HoanVi(ref arr[minIdx], ref arr[i]);
                if (!swaped)
                {
                    break;
                }
            }
        }
        public int PhanDoan(int left, int right)
        {
            int mid = (left + right) / 2;
            int pivot = arr[mid];
            int l = left;
            int r = right - 1;
            while (l <= r)
            {
                while (arr[l] < pivot) l++;
                while (arr[r] > pivot) r--;

                if (l >= r) break;
                HoanVi(ref arr[l], ref arr[r]);
                l++;
                r--;
            }
            HoanVi(ref arr[l], ref arr[r]);
            return l;
        }
        public void QuickSort(int left, int right)
        {
            if (left < right)
            {
                int p = PhanDoan(left, right);

                QuickSort(left, p - 1);
                QuickSort(p + 1, right);
            }
        }
        public int[] ShellSort()
        {
            for (int interval = arr.Length / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < arr.Length; i++)
                {
                    var currentKey = arr[i];
                    var k = i;

                    while (k >= interval && arr[k - interval] > currentKey)
                    {
                        arr[k] = arr[k - interval];
                        k -= interval;
                    }

                    arr[k] = currentKey;
                }
            }

            return arr;
        }
        public void Sort()
        {
            if (arr == null || arr.Length <= 1)
                return;

            int n = arr.Length;
            int[] temp = new int[n];
            MergeSortHelper(arr, temp, 0, n - 1);
        }
        private  void MergeSortHelper(int[] arr, int[] temp, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSortHelper(arr, temp, left, mid);
                MergeSortHelper(arr, temp, mid + 1, right);

                Merge(temp, left, mid, right);
            }
        }
        private  void Merge(int[] temp, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int k = left;

            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k] = arr[i];
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                }
                k++;
            }

            while (i <= mid)
            {
                temp[k] = arr[i];
                i++;
                k++;
            }

            while (j <= right)
            {
                temp[k] = arr[j];
                j++;
                k++;
            }

            for (k = left; k <= right; k++)
            {
                arr[k] = temp[k];
            }
        }
    }
}
