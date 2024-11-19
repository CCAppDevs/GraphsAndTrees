using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphsAndTrees
{
    public class Vertex
    {
        public string Location { get; set; }
        public List<Edge> Edges { get; private set; }

        public string StateCode { get; set; } // two letter code
        public string CountryCode { get; set; }

        public Vertex(string location, string state = "WA", string country = "USA")
        {
            Location = location;
            StateCode = state;
            CountryCode = country;
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
