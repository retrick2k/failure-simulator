namespace FailureSimulator.Core.Graph
{
    /// <summary>
    /// Ребро
    /// </summary>
    public class Edge
    {
        /// <summary>
        /// Длина связи
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Удельная интенсивость отказов
        /// </summary>
        public double SpecificIntensity { get; set; }

        /// <summary>
        /// Интенсивность отказов всей связи
        /// </summary>
        public double Intensity => Length * SpecificIntensity;

        /// <summary>
        /// Вершина, в которую направлено ребро
        /// </summary>
        public Vertex Vertex { get; private set; }


        public Edge(Vertex vertex)
        {
            Vertex = vertex;
        }

        public Edge(Vertex vertex, double length, double intensiy) : this(vertex)
        {
            Length = length;
            SpecificIntensity = intensiy;
        }

        public override string ToString() => $"{Vertex.Name} ({Length})";

    }
}