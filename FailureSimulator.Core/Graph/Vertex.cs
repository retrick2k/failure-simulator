using System.Collections.Generic;
using System.Linq;

namespace FailureSimulator.Core.Graph
{
    /// <summary>
    /// Узел (вершина) графа
    /// </summary>
    public class Vertex
    {
        public string Name { get; set; }
        public List<(Element Element, int Amount)> Elements { get; private set; }
        public List<Edge> Edges { get; private set; }

        public Vertex(string name)
        {
            Name = name;
            Elements = new List<(Element Element, int Amount)>();
            Edges = new List<Edge>();
        }

        /// <summary>
        /// Находит ребро, выходящее из текущей вершины к заданной
        /// </summary>
        /// <param name="otherName">Имя вершины, куда входит ребро</param>
        /// <returns>Ребро; null, если не найдено</returns>
        public Edge GetEdge(string otherName) => Edges.FirstOrDefault(x => x.Vertex.Name == otherName);

        public override string ToString() => Name;

    }
}