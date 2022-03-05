using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Laba_2
{
    class Program
    {

        static void Main(string[] args)
        {
            int n, W;
           
            Console.WriteLine("Введите количество предметов в рюкзаке и максимальный вес");
            n = Convert.ToInt32(Console.ReadLine());
            W = Convert.ToInt32(Console.ReadLine());
            BackpackTask task = new BackpackTask(n, W);
            task.Print(); 
            
            task.knapsack_din();
            task.knapsack_greedy();
            sq_array();
            string[] a = { "aaabfh", "srrryhf", "dhhui" };
           
            Console.WriteLine(BinarySearch(task.price, 45, 0, task.price.Length - 1));
            Console.WriteLine("Было: "+a[0]+" "+a[1]+" "+a[2]);
            a = RadixSort(a, 3, 3, 3);
            Console.WriteLine("Стало: " + a[0] + " " + a[1] + " " + a[2]);
            Console.ReadKey();
        }
       
        public static void sq_array()
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            stopWatch.Start();
            char[,] array = new char[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = (char)i;
                    Console.Write(array[i, j] + " ");
                }
                Console.Write("\n");
            }
            stopWatch.Stop();
            BackpackTask task = new BackpackTask(0, 0);
            task.time(stopWatch);
        }
        static int BinarySearch(int[] array, int searchedValue, int left, int right)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            while (left <= right)
            {
                var middle = (left + right) / 2;

                if (searchedValue == array[middle])
                {
                    return middle;
                }
                else if (searchedValue < array[middle])
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            BackpackTask task = new BackpackTask(0, 0);
            task.time(stopWatch);
            return -1;
        }
        public static string[] RadixSort(string[] a, int k, int n, int m)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < k; i++)
            {
                int[] c = new int[123];
                string[] b = new string[n];
                for (int j = 97; j < 123; j++)
                {
                    c[j] = 0;
                }
                for (int j = 0; j < n; j++)
                {
                    char d = a[j][m - i - 1];
                    c[d]++;
                }
                int cou = 0;
                for (int j = 97; j < 123; j++)
                {
                    int temp = c[j];
                    c[j] = cou;
                    cou += temp;
                }
                for (int j = 0; j < n; j++)
                {
                    int d = a[j][m - i - 1];
                    b[c[d]] = a[j];
                    c[d]++;
                }
                a = b;
            }
            BackpackTask task = new BackpackTask(0, 0);
            task.time(stopWatch);
            return a;
        }
    }
}
