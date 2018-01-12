namespace FailureSimulator.Core.Graph
{
    /// <summary>
    /// Ребро
    /// </summary>
    public class Edge : IGraphUnit
    {
             
        public string Name => $"{VertexFrom} <-> {VertexTo.Name}";

        /// <summary>
        /// Интенсивность отказов всей связи
        /// </summary>
        public double FailIntensity { get; set; }

        /// <summary>
        /// Интенсивность восстановления
        /// </summary>
        public double RepairIntensity { get; set; }

        /// <summary>
        /// Вершина, в которую направлено ребро
        /// </summary>
        public Vertex VertexTo { get; private set; }


        /// <summary>
        /// Вершина, из которой направлено ребро
        /// </summary>
        public Vertex VertexFrom { get; private set; }

        public Edge(Vertex from, Vertex to, double failIntensity = 0)
        {

            VertexFrom = from;
            VertexTo = to;
            FailIntensity = failIntensity;
        }

        public override string ToString() => Name;

    }
}