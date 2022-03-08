using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер таблицы: ");
            int s = Convert.ToInt32(Console.ReadLine());
            Hash h = new Hash(s);
            Console.WriteLine("Введите добавляемый элемент");
            string add = Console.ReadLine();
            h.Add(h.Key(add.Length), add);
            Console.WriteLine("Введите добавляемый элемент");
            add = Console.ReadLine();
            h.Add(h.Key(add.Length), add);

            h.Print();

            Console.WriteLine("\nВведите искомый элемент: ");
            string search = Console.ReadLine();
            Console.WriteLine(h.Search(h.Key(search.Length), search));
            Console.WriteLine("Удалим последний добавленный элемент\n");
            h.Delete(h.Key(add.Length));
            h.Print();

            Console.WriteLine("\nВыведем хэш использующий метод цепочек для разрешения коллизий\n");
            HashList l = new HashList();
            l.Print();
            Console.ReadKey();
        }
    }
}
