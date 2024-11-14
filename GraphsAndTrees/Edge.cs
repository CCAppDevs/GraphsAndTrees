namespace GraphsAndTrees
{
    public class Edge
    {
        public int Weight { get; set; }
        public Vertex Child { get; set; }
        public Vertex Parent { get; set; }

        public Edge(Vertex parent, Vertex child, int weight)
        {
            Weight = weight;
            Child = child;
            Parent = parent;
        }

    }
}