using GraphsAndTrees;

namespace GraphTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectedGraph graph = new DirectedGraph();

            var a = graph.AddVertex("Centralia");
            var b = graph.AddVertex("Rochester");
            var c = graph.AddVertex("Olympia");
            var d = graph.AddVertex("Portland", "OR");
            var e = graph.AddVertex("Tigard", "OR");

            a.AddEdge(b, 1);
            b.AddEdge(c, 1);
            // c.AddEdge(d, 1);
            d.AddEdge(e, 1);
            e.AddEdge(a, 1);
            a.AddEdge(d, 50);

            graph.Dijkstra(4);

            graph.PrintMatrix();

            Console.ReadLine();
        }
    }
}
