using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FailureSimulator.Core.AbstractPathAlgorithms;

namespace FailureSimulator.Core.PathAlgorithms
{
    /// <summary>
    /// Находит все пути на графе.
    /// Проверяет наличие хотя бы одного пути на изменившемся графе.
    /// </summary>
    public class DfsPathFinder : IPathFinder
    {
        private readonly ComputationGraph.ComputationGraph _graph;
        private readonly List<List<int>> _pathes;


        public DfsPathFinder(ComputationGraph.ComputationGraph graph, int start, int end)
        {
            _graph = graph;
            FindAllPathes(start, end);
        }

        public IReadOnlyList<IReadOnlyList<int>> AllPathes { get; }
        public bool IsAnyPathAlive()
        {
            throw new System.NotImplementedException();
        }

        
        // Находит все пути, используя поиск в глубину
        private void FindAllPathes(int start, int end)
        {
            bool[] isVisited = new bool[_graph.VertexCount];
            var pathes = new LinkedList<List<int>>();
            var path = new LinkedList<int>();

            dfs(start, (isVisited, pathes, path, end));
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
        void dfs(int currentVertex,  (bool[] isVisted, LinkedList<List<int>> pathes, LinkedList<int> path, int target) common)
        {
            common.isVisted[currentVertex] = true;
            common.path.AddLast(currentVertex);

            if (currentVertex == common.target)
            {
                common.pathes.AddLast(common.path.ToList());
                common.path.RemoveLast();
                return;
            }

            var neighbours = _graph.GetNeighbours(currentVertex);
            foreach (var edge in neighbours)
            {
                if (common.isVisted[edge.vertex])
                    continue;

                dfs(currentVertex, common);
            }

            common.isVisted[currentVertex] = true;
            common.path.RemoveLast();
        }
    }
}