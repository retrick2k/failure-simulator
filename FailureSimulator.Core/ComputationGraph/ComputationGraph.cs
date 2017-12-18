using System.Text.RegularExpressions;

namespace FailureSimulator.Core.ComputationGraph
{
    /// <summary>
    /// Структура графа, оптимизированная для вычислений
    /// </summary>
    public class ComputationGraph
    {
        /*  Список смежности
         *  Каждая строка массива соответствует i-й вершине и хранит
         *  массив свяазанных с ней вершин (и интенсивности отказа соотв. ребер)
         */
        private (double length, int vertex)[][] _list;

        /// <summary>
        /// Число вершин
        /// </summary>
        public int VertexCount => _list.Length;

    
        ///////////////////////////////////////////////////////////////////////////////////////////
        

        /// <summary>
        /// Создает новый ComputationGraph на основе Graph
        /// </summary>
        /// <param name="graph"></param>
        public ComputationGraph(Graph.Graph graph)
        {
            _list = new (double intensity, int vertex)[graph.Vertex.Count][];

            for(int vertexIndex = 0; vertexIndex < graph.Vertex.Count; vertexIndex++)
            {
                var vertex = graph.Vertex[vertexIndex];
                _list[vertexIndex] = new (double intensity, int vertex)[vertex.Edges.Count];
                
                for(int edgeIndex = 0; edgeIndex < vertex.Edges.Count; edgeIndex++)
                {
                    var edge = vertex.Edges[edgeIndex];
                    _list[vertexIndex][edgeIndex] = (edge.Length, graph.GetVertexIndex(edge.Vertex));
                    edgeIndex++;
                }

                vertexIndex++;
            }
        }

        public void RemoveEdge(int start, int end)
        {
            
        }

        public void RemoveVertex(int vertex)
        {
            
        }

        /// <summary>
        /// Возвращает длину пути между двумя вершинами
        /// </summary>
        /// <param name="a">Индекс начальной вершины</param>
        /// <param name="b">Индекс< конечной вершины</param>
        /// <returns>Длина пути, PositiveInfinity, если пути нет</returns>
        public double GetEdgeLength(int a, int b)
        {
            //TODO: Проверка аргументов

            var edges = _list[a];
            for(int i = 0; i < edges.Length; i++)
                if (edges[i].vertex == b)
                    return edges[i].length;

            return double.PositiveInfinity;
        }
    }
}