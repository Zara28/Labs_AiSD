using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            Console.WriteLine("Введите размер кучи: ");
            s = Convert.ToInt32(Console.ReadLine());
            Heap h = new Heap(s);
            Console.WriteLine("Куча: ");
            h.outHeap();
            Console.WriteLine("Введите значение добавляемого элемента: ");
            s = Convert.ToInt32(Console.ReadLine());
            h.addelem(s);
            Console.WriteLine("Обновленная куча: ");
            h.outHeap();
			Console.WriteLine("Максимум в куче: " + h.getmax());

			int node = 0;
			int edge1 = 0;
			int edge2 = 0;
			Console.WriteLine("Введите размер графа: ");
			s = Convert.ToInt32(Console.ReadLine());
			BFS graph = new BFS(s);

			Console.WriteLine("1) Add edges");
			Console.WriteLine("Enter edge v1: ");
			edge1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nEnter edge v2: ");
			edge2 = Convert.ToInt32(Console.ReadLine());
			graph.addEdge(edge1, edge2);

			Console.WriteLine("2) Delete edge");
			Console.WriteLine("Enter edge v1: ");
			edge1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nEnter edge v2: ");
			edge2 = Convert.ToInt32(Console.ReadLine());
			graph.deleteEdge(edge1, edge2);

			Console.WriteLine("3) Print Graph");
			graph.printGraph();

			Console.WriteLine("4) Depth First Search");
			Console.WriteLine("Enter vertex (node) to search: ");
			node = Convert.ToInt32(Console.ReadLine());
			graph.bfs(node);

            Console.ReadKey();
        }
    }

   
}
