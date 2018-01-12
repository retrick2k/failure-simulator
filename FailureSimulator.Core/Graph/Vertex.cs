using System;
using System.Collections.Generic;
using System.Linq;

namespace FailureSimulator.Core.Graph
{
    /// <summary>
    /// Узел (вершина) графа
    /// </summary>
    public class Vertex : IGraphUnit
    {
        private List<Edge> _edges;

        /// <summary>
        /// Имя вершины
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Интенсивность отказов узла
        /// </summary>
        public double FailIntensity { get; set; }

        /// <summary>
        /// Интенсивность восстановления
        /// </summary>
        public double RepairIntensity { get; set; }

        /// <summary>
        /// Список ориентированных ребер, выходящих из вершины
        /// </summary>
        public IReadOnlyList<Edge> Edges => _edges.AsReadOnly();


        public Vertex(string name, double failIntensity)
        {
            Name = name;
            _edges = new List<Edge>();
            FailIntensity = failIntensity;
        }


        /// <summary>
        /// Добавляет ориентированное ребро, выходящее из вершины
        /// </summary>
        /// <param name="other">Вершина, в которую войдет ребро</param>
        /// <param name="failIntensity">Интенсивность отказов ребра</param>
        /// <returns>Созданное ребро</returns>
        public Edge AddEdge(Vertex other, double failIntensity=0)
        {
            var edge = new Edge(this, other, failIntensity);
            _edges.Add(edge);
            other._edges.Add(edge);
            return edge;
        }


        /// <summary>
        /// Удаляет ребро, ведущее к заданной вершине
        /// </summary>
        /// <param name="other">Вершина, к которой идет ребро</param>
        public void RemoveEdge(Vertex other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            RemoveEdge(other.Name);
        }

        /// <summary>
        /// Удаляет ребро, ведущее к заданной вершине
        /// </summary>
        /// <param name="otherName">Имя вершины, к которой идет ребро</param>
        /// <exception cref="ArgumentNullException">otherName - null</exception>
        /// <exception cref="ArgumentException">Указанное ребро отсутствует в графе</exception>
        public void RemoveEdge(string otherName)
        {
            if(otherName == null)
                throw new ArgumentNullException(nameof(otherName));

            var edge = GetEdge(otherName);
            if(edge == null)
                throw new ArgumentException($"Ребро {Name} - {otherName} отсутствует в графе");

            edge.VertexFrom._edges.Remove(edge);
            edge.VertexTo._edges.Remove(edge);
        }


        /// <summary>
        /// Удаляет заданное ребро
        /// </summary>
        /// <param name="edge">Ребро, которое надо удалить</param>
        /// <exception cref="ArgumentNullException">edge - null</exception>
        public void RemoveEdge(Edge edge)
        {
            if(edge == null)
                throw new ArgumentNullException(nameof(edge));

            if(!_edges.Contains(edge))
                throw new ArgumentException($"Ребро {Name} - {edge.VertexTo.Name} отсутствует в графе");

            edge.VertexFrom._edges.Remove(edge);
            edge.VertexTo._edges.Remove(edge);
        }

        /// <summary>
        /// Находит ребро, выходящее из текущей вершины к заданной
        /// </summary>
        /// <param name="otherName">Имя вершины, куда входит ребро</param>
        /// <returns>Ребро; null, если не найдено</returns>
        public Edge GetEdge(string otherName)
        {
            if(otherName == null)
                throw new ArgumentNullException(nameof(otherName));

            return Edges.FirstOrDefault(x => x.VertexTo.Name == otherName);
        }

        /// <summary>
        /// Находит ребро, выходящее из текущей вершины к заданной
        /// </summary>
        /// <param name="otherName">Вершины, куда входит ребро</param>
        /// <returns>Ребро; null, если не найдено</returns>
        public Edge GetEdge(Vertex otherVertex)
        {
            if(otherVertex == null)
                throw new ArgumentNullException(nameof(otherVertex));

            return Edges.FirstOrDefault(x => x.VertexTo == otherVertex);
        }

        public override string ToString()
        {
            return Name;
        }

    }
}