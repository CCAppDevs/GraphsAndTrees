using GraphsAndTrees;

namespace GraphTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectedGraph graph = new DirectedGraph();

            var centralia = graph.AddVertex("Centralia");
            var rochester = graph.AddVertex("Rochester");
            var oly = graph.AddVertex("Olympia  ");
            var portland = graph.AddVertex("Portland ", "OR");
            var tigard = graph.AddVertex("Tigard   ", "OR");
            var vancouver = graph.AddVertex("Vancouver", "OR");

            centralia.AddEdge(rochester, 25);
            rochester.AddEdge(centralia, 1);

            rochester.AddEdge(oly, 1);
            oly.AddEdge(rochester, 1);
            
            portland.AddEdge(tigard, 1);
            tigard.AddEdge(portland, 1);
            
            centralia.AddEdge(portland, 50);
            portland.AddEdge(centralia, 50);

            portland.AddEdge(vancouver, 5);
            vancouver.AddEdge(portland, 5);

            vancouver.AddEdge(centralia, 30);
            centralia.AddEdge(vancouver, 30);

            vancouver.AddEdge(tigard, 2);
            tigard.AddEdge(vancouver, 2);



            graph.Dijkstra(2);

            graph.PrintMatrix();

            Console.ReadLine();
        }
    }
}
