using System;
using System.Collections.Generic;
using FailureSimulator.Core.AbstractPathAlgorithms;

namespace FailureSimulator.Core.PathAlgorithms
{
    public class DijkstraPathFinder : IPathFinder
    {
        public List<int> GetPath(ComputationGraph.ComputationGraph graph, int startVertex, int endVertex)
        {
            int[] path = new int[graph.VertexCount];           // Для поиска пути
            double[] dists = new double[graph.VertexCount];    // Текущие кратчайшие расстояния
            bool[] isVisited = new bool[graph.VertexCount];    // Маркеры посещенности

            // Инициализация
            for (int i = 0; i < graph.VertexCount; i++)
            {
                path[i] = -1;
                dists[i] = double.PositiveInfinity;
                isVisited[i] = false;
            }

            dists[startVertex] = 0;

            // Поиск кратчайшего пути
            int minIndex;
            do
            {
                minIndex = GetMinNotVisited(dists, isVisited);
                if (minIndex == -1)
                    break;

                for (int i = 0; i < graph.VertexCount; i++)
                {
                    double length = graph.GetEdgeLength(minIndex, i);
                    if (!double.IsInfinity(length) && !isVisited[i])
                    {
                        double newDist = dists[minIndex] + length;
                        if (newDist < dists[i])
                        {
                            dists[i] = newDist;
                            path[i] = minIndex;
                        }
                    }
                }

                isVisited[minIndex] = true;

            } while (minIndex != -1);


            // Проврека, что путь есть
            if (path[endVertex] == -1)
                return null;

            // Составление маршрута
            var pathList = new List<int>();
            int curIndex = endVertex;

            while (curIndex != -1)
            {
                pathList.Add(curIndex);
                curIndex = path[curIndex];
            }

            pathList.Reverse();
            return pathList;
        }

        // Возвращает непосещенную вершину с минимальным кратчайшим путем
        private int GetMinNotVisited(double[] dists, bool[] isVisited)
        {
            double minDist = double.PositiveInfinity;
            int minIndex = -1;

            for (int i = 0; i < dists.Length; i++)
            {
                if (dists[i] < minDist && isVisited[i] == false)
                {
                    minDist = dists[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }
    }
}