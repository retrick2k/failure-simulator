using System.Linq;
using FailureSimulator.Core.Graph;

namespace FailureSimulator.GUI.Helpers
{
    public static class Extension
    {
        /// <summary>
        /// Находит вершину в графе с указанной вершиной (если есть)
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="vertex"></param>
        /// <returns></returns>
        public static DataVertex FindVertex(this DataGraph graph, Vertex vertex)
        {
            return graph.Vertices.FirstOrDefault(x => x.Vertex == vertex);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="vertex"></param>
        /// <returns></returns>
        public static DataVertex AddVertex(this DataGraph graph, Vertex vertex)
        {
            var dv = new DataVertex(vertex);
            graph.AddVertex(dv);
            return dv;
        }

        public static DataVertex AddVertexIfNotExists(this DataGraph graph, Vertex vertex)
        {
            var dv = graph.FindVertex(vertex);
            if (dv == null)
                dv = graph.AddVertex(vertex);

            return dv;
        }
    }
}