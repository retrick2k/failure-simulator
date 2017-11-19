using System;
using System.Collections.Generic;
using System.Linq;

namespace FailureSimulator.Core.Graph
{

    /* Да, я использую List<T>, вместо Dictionary<K, T>
     * 
     * 1. Можно переименовывать вершину и это не разрушит целостность
     * 2. По номеру вершины (полученному, например, из мат. представления, алгоритма
     *    поиска пути и т.п.) можно получить имя вершины (ладно, можно и по словарю)
     */ 
    
    /// <summary>
    /// Объект графа
    /// </summary>
    public class Graph
    {
        private List<Vertex> _vertex;

        /// <summary>
        /// Список вершин графа
        /// </summary>
        //public Dictionary<string, Vertex> Vertex { get; private set; }
        public IReadOnlyCollection<Vertex> Vertex => _vertex.AsReadOnly();

        /// <summary>
        /// Список элементов, из которых состоят вершины (узлы)
        /// </summary>
        public List<Element> Elements { get; private set; }

        public Graph()
        {
            _vertex = new List<Vertex>();
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

            if (_getVertex(vertex.Name)!=null)
                throw new ArgumentException($"Граф уже содержит вершину с именем {vertex.Name}");

            _vertex.Add(vertex);
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

            return _getVertex(vertexA).AddEdge(_getVertex(vertexB), length, intensity);
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

            if (_getVertex(vertexName)!=null)
                throw new ArgumentException($"Вершина {vertexName} отсутствует в графе");


            // Удаляем из списка вершин
            _vertex.Remove(_getVertex(vertexName));

            // Но еще надо пройтись по всем ребрам и удалить ребра, ведущие к этой вершине
            foreach (var vert in Vertex)
            {
                var edge = vert.GetEdge(vertexName);
                if (edge != null)
                    vert.RemoveEdge(edge);
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

            _getVertex(vertexA).RemoveEdge(vertexB);
        }


        /// <summary>
        /// Возвращает вершину с заданным именем
        /// </summary>
        /// <param name="vertexName">Имя вершины</param>
        /// <returns>Вершина</returns>
        public Vertex GetVertex(string vertexName)
        {
            if(vertexName == null)
                throw new ArgumentNullException(nameof(vertexName));

            return _getVertex(vertexName);
        }

        private Vertex _getVertex(string vertexName)
        {
            return _vertex.FirstOrDefault(x => x.Name == vertexName);
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

            if (GetVertex(vertexName) == null)
                throw new ArgumentException($"Вершина {vertexName} отсутствует в графе");
        }

    }

}