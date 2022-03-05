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

            var vertices = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var edges = new[]{Tuple.Create(1,2), Tuple.Create(1,3),
                Tuple.Create(2,4), Tuple.Create(3,5), Tuple.Create(3,6),
                Tuple.Create(4,7), Tuple.Create(5,7), Tuple.Create(5,8),
                Tuple.Create(5,6), Tuple.Create(8,9), Tuple.Create(9,10)};

            var graph = new Graph<int>(vertices, edges);
            var algorithms = new BFS();
            Console.WriteLine("Depth First Search\n Введите вершину (от 1 до 10), с которой хотите начать обход: ");

            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Путь в графе: "+string.Join(", ", algorithms.BFS_alg(graph, s)));
            Console.WriteLine("\n5) Алгорит Прима для поиска остовного дерева");
            Ostov.Prim();

            Console.ReadKey();
        }
    }

   
}
