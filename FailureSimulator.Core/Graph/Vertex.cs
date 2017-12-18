﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace FailureSimulator.Core.Graph
{
    /// <summary>
    /// Узел (вершина) графа
    /// </summary>
    public class Vertex
    {
        private List<Edge> _edges;

        /// <summary>
        /// Имя вершины
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Список элементов, из которых состоит вершина
        /// </summary>
        public List<(Element Element, int Amount)> Elements { get; private set; }


        /// <summary>
        /// Интенсивность отказов узла
        /// </summary>
        public double Intensity => Elements.Sum(e => e.Amount * e.Element.Intensity);

        /// <summary>
        /// Список ориентированных ребер, выходящих из вершины
        /// </summary>
        public IReadOnlyList<Edge> Edges => _edges.AsReadOnly();


        public Vertex(string name)
        {
            Name = name;
            Elements = new List<(Element Element, int Amount)>();
            _edges = new List<Edge>();
        }


        /// <summary>
        /// Добавляет ориентированное ребро, выходящее из вершины
        /// </summary>
        /// <param name="other">Вершина, в которую войдет ребро</param>
        /// <param name="length">Длина ребра</param>
        /// <param name="intentiy">Интенсивность отказов единицы длины ребра</param>
        /// <returns>Созданное ребро</returns>
        public Edge AddEdge(Vertex other, double length=0, double intentiy=0)
        {
            var edge = new Edge(other, length, intentiy);
            _edges.Add(edge);
            return edge;
        }


        /// <summary>
        /// Удаляет ребро, ведущее к заданной вершине
        /// </summary>
        /// <param name="other">Вершина, к которой идет ребро</param>
        public void RemoveEdge(Vertex other)
        {
            if (other == null)
                throw new ArgumentException(nameof(other));

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
                throw new ArgumentException(nameof(otherName));

            var edge = GetEdge(otherName);
            if(edge == null)
                throw new ArgumentException($"Ребро {Name} - {otherName} отсутствует в графе");
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

            _edges.Remove(edge);
        }

        /// <summary>
        /// Находит ребро, выходящее из текущей вершины к заданной
        /// </summary>
        /// <param name="otherName">Имя вершины, куда входит ребро</param>
        /// <returns>Ребро; null, если не найдено</returns>
        public Edge GetEdge(string otherName)
        {
            return Edges.FirstOrDefault(x => x.Vertex.Name == otherName);
        }

        /// <summary>
        /// Находит ребро, выходящее из текущей вершины к заданной
        /// </summary>
        /// <param name="otherName">Вершины, куда входит ребро</param>
        /// <returns>Ребро; null, если не найдено</returns>
        public Edge GetEdge(Vertex otherVertex)
        {
            return Edges.FirstOrDefault(x => x.Vertex == otherVertex);
        }

        public override string ToString()
        {
            return Name;
        }

    }
}