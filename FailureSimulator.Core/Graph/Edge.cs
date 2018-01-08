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
      

        /// <summary>
        /// Длина связи
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Удельная интенсивость отказов
        /// </summary>
        public double SpecificFailIntensity { get; set; }

        public string Name => $"{_vertexFrom} -> {VertexTo.Name}";

        /// <summary>
        /// Интенсивность отказов всей связи
        /// </summary>
        public double FailIntensity => Length * SpecificFailIntensity;

        /// <summary>
        /// Интенсивность восстановления
        /// </summary>
        public double RepairIntensity { get; set; }

        /// <summary>
        /// Вершина, в которую направлено ребро
        /// </summary>
        public Vertex VertexTo { get; private set; }


        public Edge(Vertex from, Vertex to, double length = 0, double intensiy = 0)
        {

            _vertexFrom = from;
            VertexTo = to;
            Length = length;
            SpecificFailIntensity = intensiy;
        }

        public override string ToString() => Name;

    }
}