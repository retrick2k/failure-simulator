namespace FailureSimulator.Core.Graph
{
    /// <summary>
    /// Элемент, из которого состоят вершины
    /// </summary>
    public class Element
    {
        /// <summary>
        /// Название элемента
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Интенсивность отказов элементов
        /// </summary>
        public double Intensity { get; set; }


        public Element(string name, double intensity)
        {
            Name = name;
            Intensity = intensity;
        }

        public override string ToString() => $"{Name} ({Intensity})";
    }
}