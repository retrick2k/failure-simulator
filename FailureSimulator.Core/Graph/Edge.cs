namespace FailureSimulator.Core.Graph
{
    /// <summary>
    /// Ребро
    /// </summary>
    public class Edge : IGraphUnit
    {
        /// <summary>
        /// Длина связи
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Удельная интенсивость отказов
        /// </summary>
        public double SpecificFailIntensity { get; set; }

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
        public Vertex Vertex { get; private set; }


        public Edge(Vertex vertex, double length = 0, double intensiy = 0)
        {
            Vertex = vertex;
            Length = length;
            SpecificFailIntensity = intensiy;
        }

        public override string ToString() => $"{Vertex.Name} ({Length})";

    }
}