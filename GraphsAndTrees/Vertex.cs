using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphsAndTrees
{
    public class Vertex
    {
        public string Label { get; set; }
        public List<Edge> Edges { get; private set; }

        public Vertex(string label)
        {
            Label = label;
            Edges = new List<Edge>();
        }

        public void AddEdge(Edge edge)
        {
            Edges.Add(edge);
        }

        public void AddEdge(Vertex child, int weight)
        {
            Edges.Add(new Edge(this, child, weight));
        }
    }

}
