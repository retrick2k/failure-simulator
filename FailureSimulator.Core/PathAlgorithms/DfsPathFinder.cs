using System.Collections.Generic;
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
        public IReadOnlyList<IReadOnlyList<GraphUnit>> FindAllPathes(Graph.Graph graph, GraphUnit start, GraphUnit end)
        {
            var isVisited = new Dictionary<GraphUnit, bool>();
            var pathes = new LinkedList<List<GraphUnit>>();
            var path = new LinkedList<GraphUnit>();

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
        public IReadOnlyList<IReadOnlyList<GraphUnit>> FindAllPathes(Graph.Graph graph, string start, string end)
        {
            GraphUnit startGraphUnit = graph.GetVertex(start);
            GraphUnit endGraphUnit = graph.GetVertex(end);
            return FindAllPathes(graph, startGraphUnit, endGraphUnit);
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
        void dfs(GraphUnit currentGraphUnit,  (Dictionary<GraphUnit, bool> isVisted, LinkedList<List<GraphUnit>> pathes, LinkedList<GraphUnit> path, GraphUnit target) common)
        {
            common.isVisted[currentGraphUnit] = true;
            common.path.AddLast(currentGraphUnit);

            if (currentGraphUnit == common.target)
            {
                common.pathes.AddLast(common.path.ToList());
                common.path.RemoveLast();
                common.isVisted[currentGraphUnit] = false;
                return;
            }

            foreach (var edge in currentGraphUnit.Edges)
            {
                if (common.isVisted[edge.GraphUnit])
                    continue;

                dfs(edge.GraphUnit, common);
            }

            common.isVisted[currentGraphUnit] = false;
            common.path.RemoveLast();
        }
    }
}