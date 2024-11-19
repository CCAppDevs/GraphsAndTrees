using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphsAndTrees
{
    public class DirectedGraph
    {
        public int NumVertices { get => Vertices.Count; }
        public List<Vertex> Vertices = new List<Vertex>();

        public Vertex AddVertex(string location, string state = "WA", string country = "USA")
        {
            Vertex v = new Vertex(location, state, country);
            Vertices.Add(v);
            return v;
        }

        public int[,] CreateAdjMatrix()
        {
            int[,] AdjMatrix = new int[Vertices.Count, Vertices.Count];

            for (int i = 0; i < Vertices.Count; i++)
            {
                Vertex v1 = Vertices[i];

                for (int j = 0; j < Vertices.Count; j++)
                {
                    Vertex v2 = Vertices[j];

                    Edge edge = v1.Edges.FirstOrDefault(e => e.Child == v2);

                    if (edge != null)
                    {
                        AdjMatrix[i, j] = edge.Weight;
                    }
                }
            }

            return AdjMatrix;
        }

        public void PrintMatrix()
        {
            var matrix = CreateAdjMatrix();

            Console.Write("\t");
            for (int i = 0; i < Vertices.Count; i++)
            {
                Console.Write($" {Vertices[i].Location} ");
            }
            Console.WriteLine();


            for (int i = 0; i < Vertices.Count; i++)
            {
                Console.Write($"{Vertices[i].Location}\t");

                for (int j = 0; j < Vertices.Count; j++)
                {
                    if (matrix[i, j] != null)
                    {
                        Console.Write($"[{matrix[i, j].ToString()}]");
                    }
                    else
                    {
                        Console.Write("[.]");
                    }
                }
                Console.WriteLine();
            }
        }

        public void Dijkstra(int source)
        {
            int[,] graph = CreateAdjMatrix();

            int[] dist = new int[Vertices.Count];
            bool[] visits = new bool[Vertices.Count];

            // init the arrays
            for (int i = 0; i < Vertices.Count; i++)
            {
                dist[i] = int.MaxValue;
                visits[i] = false;
            }

            dist[source] = 0;

            // start the algo
            for (int count = 0; count < Vertices.Count - 1; count++)
            {
                // pick minimum distance vertex
                // from the set of verts not yet processed

                int u = MinDistance(dist, visits);
                visits[u] = true; // we have now visited U

                // update dist values of adjacent verts to U
                for (int v = 0; v < Vertices.Count; v++)
                {
                    // the magic algo
                    /*
                     update dist[v] only if the following conditions are true:
                        it is not visited,
                        there exists an edge from u to v,
                        the edge is not infinity,
                        the total weight of the path from src to v through the picked node (u) is smaller than the current value of dist[v]
                     */
                    if (!visits[v] &&
                        graph[u, v] != 0 &&
                        dist[u] != int.MaxValue &&
                        dist[u] + graph[u,v] < dist[v]
                        )
                    {
                        dist[v] = dist[u] + graph[u, v];
                    }
                }
            }

            for (int i = 0; i < dist.Length; i++)
            {
                Console.WriteLine($"Distance from { Vertices[source].Location } to { Vertices[i].Location }: { dist[i] }");
            }
        }

        public int MinDistance(int[] dist, bool[] visited)
        {
            int min_dist = Int32.MaxValue;
            int min_index = -1;

            for (int i = 0; i < Vertices.Count; i++)
            {
                if (visited[i] == false && dist[i] <= min_dist)
                {
                    min_dist = dist[i];
                    min_index = i;
                }
            }

            return min_index;
        }
    }
}
