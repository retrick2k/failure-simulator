using System;
using System.Collections.Generic;
using System.Linq;

namespace FailureSimulator.Core.Graph
{

    /*
    *                        ВНИМАНИЕ
    * Данная реализация может привести к проблемам с целостностью
    *
    * 1. Можно спокойно добавлять/удалять вершины
    * 2. Можно спокойно менять свойства вершин, ОСОБЕННО ИМЯ
    * 3. Можно спокойно удалять/добавлять ребра у вершин
    */

    /// <summary>
    /// Объект графа
    /// </summary>
    public class Graph
    {
        /// <summary>
        /// Список вершин графа
        /// </summary>
        public Dictionary<string, Vertex> Vertex { get; private set; }

        /// <summary>
        /// Список элементов, из которых состоят вершины (узлы)
        /// </summary>
        public List<Element> Elements { get; private set; }

        public Graph()
        {
            Vertex = new Dictionary<string, Vertex>();
            Elements = new List<Element>();
        }


        /// <summary>
        /// Добавляет новую вершину в граф
        /// </summary>
        /// <param name="vertex">Вершина</param>
        public void AddVertex(Vertex vertex)
        {
            if (vertex == null)
                throw new ArgumentNullException(nameof(vertex));

            if (Vertex.ContainsKey(vertex.Name))
                throw new ArgumentException($"Граф уже содержит вершину с именем {vertex.Name}");

            Vertex.Add(vertex.Name, vertex);
        }

        /// <summary>
        /// Добавляет новое ориентированное ребро между двумя вершинами в граф
        /// </summary>
        /// <param name="vertexA">Имя вершины, из которой выходит ребро</param>
        /// <param name="vertexB">Имя вершины, в которую входит ребро</param>
        /// <param name="length">Длина ребра</param>
        /// <param name="intensity">Интенсивность отказов на единицу длины ребра</param>
        /// <returns>Созданное ребро</returns>
        public Edge AddEdge(string vertexA, string vertexB, double length = 0, double intensity = 0)
        {
            AssertVertexName(vertexA);
            AssertVertexName(vertexB);

            var edge = new Edge(Vertex[vertexB], length, intensity);
            Vertex[vertexA].Edges.Add(edge);

            return edge;
        }

        /// <summary>
        /// Удаляет вершину из графа
        /// </summary>
        /// <param name="vertex">Вершина</param>
        public void RemoveVertex(Vertex vertex)
        {
            if (vertex == null)
                throw new ArgumentNullException(nameof(vertex));

            RemoveVertex(vertex.Name);
        }


        /// <summary>
        /// Удаляет вершину из графа
        /// </summary>
        /// <param name="vertexName">Имя вершины</param>
        public void RemoveVertex(string vertexName)
        {
            if (vertexName == null)
                throw new ArgumentNullException(nameof(vertexName));

            if (!Vertex.ContainsKey(vertexName))
                throw new ArgumentException($"Вершина {vertexName} отсутствует в графе");


            // Удаляем из списка вершин
            Vertex.Remove(vertexName);

            // Но еще надо пройтись по всем ребрам и удалить ребра, ведущие к этой вершине
            foreach (var vert in Vertex)
            {
                var edge = vert.Value.GetEdge(vertexName);
                if (edge != null)
                    vert.Value.Edges.Remove(edge);
            }
        }


        /// <summary>
        /// Удаляет ориентированное ребро между двумя вершинами из графа
        /// </summary>
        /// <param name="vertexA">Имя вершины, из которой выходит ребро</param>
        /// <param name="vertexB">Имя вершины, в которую входит ребро</param>
        public void RemoveEdge(string vertexA, string vertexB)
        {
            AssertVertexName(vertexA);
            AssertVertexName(vertexB);

            var a = Vertex[vertexA];
            var edge = a.GetEdge(vertexB);
            if (edge == null)
                throw new ArgumentException($"Ребро {vertexA} - {vertexB} отсутствует в графе");

            a.Edges.Remove(edge);
        }


        /// <summary>
        /// Переименовывает вершину
        /// </summary>
        /// <param name="oldName"></param>
        /// <param name="newName"></param>
        public void RenameVertex(string oldName, string newName)
        {
            AssertVertexName(oldName);

            var vertex = Vertex[oldName];
            vertex.Name = newName;
            Vertex.Remove(oldName);
            AddVertex(vertex);
        }


        /// <summary>
        /// Возвращает вершину с заданным именем
        /// </summary>
        /// <param name="name">Имя вершины</param>
        /// <returns>Вершина</returns>
        public Vertex GetVertex(string name)
        {
            AssertVertexName(name);
            return Vertex[name];
        }


        /// <summary>
        /// Проверяет, что имя вершины не NULL и она содержится
        /// в графе
        /// </summary>
        /// <param name="vertexName">Имя вершины</param>
        private void AssertVertexName(string vertexName)
        {
            if (vertexName == null)
                throw new ArgumentNullException(nameof(vertexName));

            if (!Vertex.ContainsKey(vertexName))
                throw new ArgumentException($"Вершина {vertexName} отсутствует в графе");
        }
    }

}