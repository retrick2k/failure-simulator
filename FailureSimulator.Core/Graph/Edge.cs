namespace FailureSimulator.Core.Graph
{
    /// <summary>
    /// Ребро
    /// </summary>
    public class Edge : IGraphUnit
    {
        // Костыль, но исключительно чтобы можно было выводить имена вида
        // от -> до
        private Vertex _vertexFrom;
             
        
        public string Name => $"{_vertexFrom} -> {VertexTo.Name}";

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


        public Edge(Vertex from, Vertex to, double failIntensity = 0)
        {

            _vertexFrom = from;
            VertexTo = to;
            FailIntensity = failIntensity;
        }

        public override string ToString() => Name;

    }
}