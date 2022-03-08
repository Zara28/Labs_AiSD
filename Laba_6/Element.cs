using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6
{
        public class Graph
        {

        public struct Family
        {
            public string Sorname;
            public int count;
            public Stack<string> names;
            public int index;

        }
            public List<Family> vertex = new List<Family>();
            public List<string> eges = new List<string>();
            int C = 0;
            public Graph()
            {
        
            }


            public void AddVertex(string name, int count, Stack<string> names)
            {
                Family f = new Family ();
                f.Sorname = name;
                f.count = count;
                f.names = names;
                f.index = C;
                vertex.Add(f);
                C++;
            }

            public void AddEdge(int index1, int index2)
            {
                eges.Add(index1 + ":"+index2);
            }
            public void print()
            {
                for(int i = 0; i<C; i++)
                {
                    Console.WriteLine(vertex[i].Sorname+":");
                    for(int j = 0; j<eges.Count; j++)
                    {
                        string[] ind = eges[j].Split(':');
                        if(ind[0]==Convert.ToString(vertex[i].index))
                        {
                            Console.WriteLine(vertex[Convert.ToInt32(ind[1])].Sorname+" ");
                        }
                    }
                }
            }
            public void print_elem(string sornname)
            {
            Family family = new Family();
                foreach(var f in vertex)
                {
                    if (f.Sorname == sornname)
                    {
                        family = f;
                        break;
                    }
                    
                }
                if (family.Sorname == "")
            {
                return;
            }
            Console.WriteLine("Фамилия: {0} Количество человек: {1} Имена:", family.Sorname, family.count);
            while(family.names!=null)
            {
                Console.WriteLine(family.names.Pop());
            }
            }
        }
}
