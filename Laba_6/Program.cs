using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            Queue<string> sornames = new Queue<string>();
            for (int i = 0; i<5; i++)
            {
                sornames.Enqueue(Console.ReadLine());
                k++;
            }

            Graph g = new Graph();
            for (int i = 0; i<k; i++)
            {
                Console.WriteLine("\nВведите количество человек: ");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nВведите имена через пробел: ");
                string ch = Console.ReadLine();
                string[] h = ch.Split(' ');
                Stack<string> d = new Stack<string>();
                foreach(string r in h)
                {
                    d.Push(r);
                }
                g.AddVertex(sornames.Dequeue(), c, d);
                Console.WriteLine("\nВведите номер семьи, с которой связана эта семья:");
                try
                {

                    int y = Convert.ToInt32(Console.ReadLine());
                    g.AddEdge(y, i);
                }
                catch
                {

                }
            }
            g.print();
            Console.WriteLine("Выведем информацию о первой семье: ");
            g.print_elem(g.vertex[0].Sorname);
            Console.ReadKey();
        }
    }
}
