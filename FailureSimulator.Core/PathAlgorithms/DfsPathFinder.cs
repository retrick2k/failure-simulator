﻿using System.Collections.Generic;
using System.Linq;
using FailureSimulator.Core.Graph;
using System.Reflection;
using FailureSimulator.Core.AbstractPathAlgorithms;

namespace FailureSimulator.Core.PathAlgorithms
{
    /// <summary>
    /// Находит все пути на графе.
    /// </summary>
    public class DfsPathFinder : IPathFinder
    {
        /// <summary>
        /// Возвращает список всех путей от одной вершины до другой
        /// </summary>
        /// <param name="graph">Граф</param>
        /// <param name="start">Начальная вершина</param>
        /// <param name="end">Конечная вершина</param>
        /// <returns>Список путей; путь - список вершин</returns>
        public IReadOnlyList<IReadOnlyList<Vertex>> FindAllPathes(Graph.Graph graph, Vertex start, Vertex end)
        {
            var isVisited = new Dictionary<Vertex, bool>();
            var pathes = new LinkedList<List<Vertex>>();
            var path = new LinkedList<Vertex>();

            foreach (var vertex in graph.Vertex)
                isVisited.Add(vertex, false);
            
            dfs(start, (isVisited, pathes, path, end));
            return pathes.ToList().AsReadOnly();
        }

        /// <summary>
        /// Возвращает список всех путей от одной вершины до другой
        /// </summary>
        /// <param name="graph">Граф</param>
        /// <param name="start">Имя начальной вершина</param>
        /// <param name="end">Имя конечной вершина</param>
        /// <returns>Список путей; путь - список вершин</returns>
        public IReadOnlyList<IReadOnlyList<Vertex>> FindAllPathes(Graph.Graph graph, string start, string end)
        {
            Vertex startVertex = graph.GetVertex(start);
            Vertex endVertex = graph.GetVertex(end);
            return FindAllPathes(graph, startVertex, endVertex);
        }

        /* Поиск в глубину и составление пути
         *  1. Каждый раз, когда проходим очередную вершину, добавляем ее
         *     во временный path
         *  2. Если вершина конечная - полученный path добавляем в список путей
         *  2. Затем рекурсивно переходим во все не посещенные в текущем
         *     поддереве вершины
         *  
         *  Каждый раз при выходе на уровень вверх, мы движемся к предыдущей развилке,
         *  поэтому последнюю вершину удаляем. Выполняя это мы гарантируем, что в любом случае
         *  текущая вершина - последняя в списке, поэтому так можно делать.
         *  
         *  Мы отмечаем вершину в начале ф-ии и снимаем отметку в конце. Таким образом, вершина
         *  однократно посещается, но не вообще, а только в пределах текущего пути (т.е. в одном пути
         *  вершина встречается один раз, но может встречаться в нескольких
         */
        void dfs(Vertex currentVertex,  (Dictionary<Vertex, bool> isVisted, LinkedList<List<Vertex>> pathes, LinkedList<Vertex> path, Vertex target) common)
        {
            common.isVisted[currentVertex] = true;
            common.path.AddLast(currentVertex);

            if (currentVertex == common.target)
            {
                common.pathes.AddLast(common.path.ToList());
                common.path.RemoveLast();
                common.isVisted[currentVertex] = false;
                return;
            }

            foreach (var edge in currentVertex.Edges)
            {
                if (common.isVisted[edge.VertexTo] && common.isVisted[edge.VertexFrom])
                    continue;

                if(edge.VertexTo != currentVertex)
                    dfs(edge.VertexTo, common);
                else
                    dfs(edge.VertexFrom, common);
            }

            common.isVisted[currentVertex] = false;
            common.path.RemoveLast();
        }
    }
}