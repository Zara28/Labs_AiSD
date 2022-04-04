using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3
{
    class Heap
    {
    int SIZE = 100;
    int HeapSize;
    public int[] h;
    public Heap(int size) // конструктор кучи
    {
            HeapSize = size;
            Random r = new Random();
            h = new int[SIZE];
            for(int i = 0; i<HeapSize; i++)
            {
                h[i] = r.Next(SIZE) + 1;
            }
            for (int i = HeapSize / 2; i >= 0; i--)
            {
                heapify(i);
            }

        }
        public void addelem(int n) // добавление элемента кучи
    {
            int y, parent;
            y = HeapSize;
            h[y] = n;

            for (int i = HeapSize; i >= 0; i--)
            {
                heapify(i);
            }
           
            HeapSize++;
            for (int i = HeapSize / 2; i >= 0; i--)
            {
                heapify(i);
            }
        }
        public void outHeap()// вывод элементов кучи в форме кучи
    {
            int i = 0;
            int k = 1;
            while (i < HeapSize)
            {
                while ((i < k) && (i < HeapSize))
                {
                   Console.Write(h[i] + " ");
                    if(i%2!=0)
                    {
                        Console.Write("    ");
                    }
                    i++;
                }
                Console.Write("\n");
                k = k * 2 + 1;
            }
        }
        public int getmax()// удаление вершины (максимального элемента)
    {
            int x;
            x = h[0];
            h[0] = h[HeapSize - 1];
            HeapSize-=1;
            heapify(0);
            return x;
        }
    public void heapify(int i)// упорядочение кучи
    {
            int left, right;
            int temp;
            left = 2 * i + 1;
            right = 2 * i + 2;
            if (left < HeapSize)
            {
                if (h[i] < h[left])
                {
                    temp = h[i];
                    h[i] = h[left];
                    h[left] = temp;
                    heapify(left);
                }
            }
            if (right < HeapSize)
            {
                if (h[i] < h[right])
                {
                    temp = h[i];
                    h[i] = h[right];
                    h[right] = temp;
                    heapify(right);
                }
            }
        }
    }
}
