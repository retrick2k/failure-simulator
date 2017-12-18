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
     * 3. Можно делать AsReadOnly()
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
        public IReadOnlyList<Vertex> Vertex => _vertex.AsReadOnly();

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
        /// <exception cref="ArgumentNullException">vertex - NULL</exception>
        /// <exception cref="ArgumentException">Граф уже содержит указанную вершину</exception>
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
        /// <exception cref="ArgumentNullException">Одна из указанных вершин - null</exception>
        /// <exception cref="ArgumentException">Одна из указанных вершин отсутствует в графе</exception>
        public Edge AddEdge(string vertexA, string vertexB, double length = 0, double intensity = 0)
        {
            AssertVertexExists(vertexA);
            AssertVertexExists(vertexB);

            return _getVertex(vertexA).AddEdge(_getVertex(vertexB), length, intensity);
        }

        /// <summary>
        /// Добавляет новое ориентированное ребро между двумя вершинами в граф
        /// </summary>
        /// <param name="vertexA">Вершина, из которой выходит ребро</param>
        /// <param name="vertexB">Вершина, в которую входит ребро</param>
        /// <param name="length">Длина ребра</param>
        /// <param name="intensity">Интенсивность отказов на единицу длины ребра</param>
        /// <returns>Созданное ребро</returns>
        public Edge AddEdge(Vertex vertexA, Vertex vertexB, double length = 0, double intensity = 0)
        {
            AssertVertexExists(vertexA);
            AssertVertexExists(vertexB);

            return vertexA.AddEdge(vertexB, length, intensity);
        }


        /// <summary>
        /// Удаляет вершину из графа
        /// </summary>
        /// <param name="vertex">Вершина</param>
        /// <exception cref="ArgumentNullException">vertex - Null</exception>
        /// <exception cref="ArgumentException">Вершина отсутствует в графе</exception>
        public void RemoveVertex(Vertex vertex)
        {
            if (vertex == null)
                throw new ArgumentNullException(nameof(vertex));

            if(!_vertex.Remove(vertex))
                throw new ArgumentException($"Вершина {vertex.Name} отсутствует в графе");

            // Но еще надо пройтись по всем ребрам и удалить ребра, ведущие к этой вершине
            foreach (var vert in Vertex)
            {
                var edge = vert.GetEdge(vertex);
                if (edge != null)
                    vert.RemoveEdge(edge);
            }
        }


        /// <summary>
        /// Удаляет вершину из графа
        /// </summary>
        /// <param name="vertexName">Имя вершины</param>
        /// <exception cref="ArgumentNullException">vertexName - null</exception>
        /// <exception cref="ArgumentException">Вершина с указанным именем отсутствует в графе</exception>
        public void RemoveVertex(string vertexName)
        {
            if (vertexName == null)
                throw new ArgumentNullException(nameof(vertexName));

            AssertVertexExists(vertexName);

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
        /// <exception cref="ArgumentNullException">Одна из указанных вершин - null</exception>
        /// <exception cref="ArgumentException">Одна из указанных вершин отсутствует в графе</exception>
        public void RemoveEdge(string vertexA, string vertexB)
        {
            AssertVertexExists(vertexA);
            AssertVertexExists(vertexB);

            _getVertex(vertexA).RemoveEdge(vertexB);
        }


        /// <summary>
        /// Удаляет ориентированное ребро между двумя вершинами из графа
        /// </summary>
        /// <param name="vertexA">Вершина, из которой выходит ребро</param>
        /// <param name="vertexB">Вершины, в которую входит ребро</param>
        /// <exception cref="ArgumentNullException">Одна из указанных вершин - null</exception>
        /// <exception cref="ArgumentException">Одна из указанных вершин отсутствует в графе</exception> 
        public void RemoveEdge(Vertex vertexA, Vertex vertexB)
        {
            AssertVertexExists(vertexA);
            AssertVertexExists(vertexB);

            vertexA.RemoveEdge(vertexB);
        }


        /// <summary>
        /// Возвращает вершину с заданным именем
        /// </summary>
        /// <param name="vertexName">Имя вершины</param>
        /// <returns>Вершина</returns>
        /// <exception cref="ArgumentNullException">vertexName - null</exception>
        public Vertex GetVertex(string vertexName)
        {
            if(vertexName == null)
                throw new ArgumentNullException(nameof(vertexName));

            return _getVertex(vertexName);
        }


        /// <summary>
        /// Определяет индекс вершины по вершине
        /// </summary>
        /// <param name="vertex">Вершина</param>
        /// <returns>Индекс найденной вершины</returns>
        /// <exception cref="ArgumentNullException">vertex - null</exception>
        /// <exception cref="ArgumentException">Указанная вершина не найдена в графе</exception>
        public int GetVertexIndex(Vertex vertex)
        {
            if(vertex == null)
                throw new ArgumentNullException(nameof(vertex));

            for(int i = 0; i < _vertex.Count; i++)
                if (vertex == _vertex[i])
                    return i;

            throw new ArgumentException($"Вершина {vertex.Name} отсутствует в графе");
        }


        /// <summary>
        /// Определяет индекс вершины по имени вершины
        /// </summary>
        /// <param name="vertexName">Имя вершины</param>
        /// <returns>Индекс найденной вершины</returns>
        /// <exception cref="ArgumentNullException">vertex - null</exception>
        /// <exception cref="ArgumentException">Вершина с указанным именем отсутствует в графе</exception>
        public int GetVertexIndex(string vertexName)
        {
            if (vertexName == null)
                throw new ArgumentNullException(nameof(vertexName));

            for (int i = 0; i < _vertex.Count; i++)
                if (vertexName == _vertex[i].Name)
                    return i;

            throw new ArgumentException($"Вершина {vertexName} отсутствует в графе");
        }


        ///////////////////////////////////////////////////////////////////////////////////////////


        private Vertex _getVertex(string vertexName)
        {
            return _vertex.FirstOrDefault(x => x.Name == vertexName);
        }


        /// <summary>
        /// Проверяет, что имя вершины не NULL и она содержится в графе
        /// </summary>
        /// <param name="vertexName">Имя вершины</param>
        /// <exception cref="ArgumentException">Вершина с указанным именем отсутствует в графе</exception>
        private void AssertVertexExists(string vertexName)
        {
            if (GetVertex(vertexName) == null)
                throw new ArgumentException($"Вершина {vertexName} отсутствует в графе");
        }


        /// <summary>
        /// Проверяет, что вершина не NULL и она содержится в графе
        /// </summary>
        /// <param name="vertex"></param>
        public void AssertVertexExists(Vertex vertex)
        {
            if(!_vertex.Contains(vertex))
                throw new ArgumentException($"Вершина {vertex.Name} отсутствует в графе");
        }

    }

}