using GraphsAndTrees;

namespace GraphTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectedGraph graph = new DirectedGraph();

            var a = graph.AddVertex("a");
            var b = graph.AddVertex("b");
            var c = graph.AddVertex("c");
            var d = graph.AddVertex("d");
            var e = graph.AddVertex("e");

            a.AddEdge(b, 1);
            b.AddEdge(c, 1);
            c.AddEdge(d, 1);
            d.AddEdge(e, 1);
            e.AddEdge(a, 1);

            a.AddEdge(d, 50);

            graph.PrintMatrix();

            Console.ReadLine();
        }
    }
}
