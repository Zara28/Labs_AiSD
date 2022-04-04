using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Laba_3
{
    class Ostov
    {
        public static void time(Stopwatch stopWatch)
        {
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = Convert.ToString(ts.Ticks);
            Console.WriteLine("\n Время выполнения алгоритма: " + elapsedTime);
        }
        static int[,] G = new int[5,5] { {0, 9, 75, 0, 0}, {9, 0, 95, 19, 42}, {75, 95, 0, 51, 66}, {0, 19, 51, 0, 31}, {0, 42, 66, 31, 0}};
        public static void Prim()
        {
            Stopwatch stop = new Stopwatch();
            stop.Start();
            int V = 5;
            int no_edge;  
            int [] selected = new int [5];


            no_edge = 0;

            selected[0] = 1;

            int x;            
            int y;            

          
            Console.WriteLine("Edge : Weight");
            while (no_edge < V - 1)
            {

                int min = 10000000;
                x = 0;
                y = 0;

                for (int i = 0; i < V; i++)
                {
                    if (selected[i]==1)
                    {
                        for (int j = 0; j < V; j++)
                        {
                            if (selected[j]==0 && G[i,j]!=null)
                            { 
                                if (min > G[i,j])
                                {
                                    min = G[i,j];
                                    x = i;
                                    y = j;
                                }

                            }
                        }
                    }
                }
                Console.WriteLine(Convert.ToString(x) + " - "+ Convert.ToString(y) + " :  " + Convert.ToString(G[x,y]));
                selected[y] = 1;
                no_edge++;
            }
            stop.Stop();
            time(stop);
        }
    }

}
