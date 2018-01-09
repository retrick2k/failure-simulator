using FailureSimulator.Core.Graph;
using GraphX.Controls;
using GraphX.PCL.Common.Models;
using QuickGraph;

namespace FailureSimulator.GUI.Helpers
{
    public class MGraphArea : GraphArea<DataVertex, DataEdge, BidirectionalGraph<DataVertex, DataEdge>>
    {
        public MGraphArea()
        {
        }
    }

    public class DataVertex : VertexBase
    {
        public Vertex Vertex { get; set; }

        public DataVertex(Vertex vertex)
        {
            Vertex = vertex;
        }

        public override string ToString()
        {
            return Vertex.Name;
        }
    }

    public class DataEdge : EdgeBase<DataVertex>
    {
        public Edge Edge { get; set; }

        public DataEdge(Edge edge, DataVertex source, DataVertex target, double weight = 1) : base(source, target, weight)
        {
            Edge = edge;
        }

        public override string ToString()
        {
            return null;
        }
    }

    public class DataGraph : BidirectionalGraph<DataVertex, DataEdge> { }
}