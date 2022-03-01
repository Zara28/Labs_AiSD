using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3
{
    class BFS
    {
      
    }
    class Graf
    {
        List<Vertex> V;
        List<Edge> E;
        Graf()
        {
            V = new List<Vertex>();
            E = new List<Edge>();
        }
        Graf(List<Vertex> V1, List<Edge> E1)
        {
            V = V1;
            E = E1;
        }
    }


    class Vertex
    {
        public int x, y;
        public Color color;
        public int Vertex_Stepen;
        public int Vertex_number;



        public Vertex(int x, int y)
        {
            this.x = x;
            this.y = y;
            color = Color.White;
            Vertex_number = 0;
            Vertex_Stepen = 0;
        }

        public Vertex(int x, int y, Color c)
        {
            this.x = x;
            this.y = y;
            color = c;
            Vertex_number = 0;
            Vertex_Stepen = 0;
        }
    }

    class Edge
    {
        //номера вершин
        public int v0;
        public int v1;


        public Edge(int v0, int v1)
        {
            this.v0 = v0;
            this.v1 = v1;
        }
    }
}
