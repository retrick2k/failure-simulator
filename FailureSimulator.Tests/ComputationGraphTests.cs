using System;
using FailureSimulator.Core.ComputationGraph;
using FailureSimulator.Core.Graph;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FailureSimulator.Tests
{
    [TestClass]
    public class ComputationGraphTests
    {
        [TestMethod]
        public void CreateComputationGraph_ok()
        {
            var graph = new Graph();
            graph.AddVertex(new Vertex("vertex1"));
            graph.AddVertex(new Vertex("vertex2"));
            graph.AddVertex(new Vertex("vertex3"));

            graph.AddEdge("vertex1", "vertex2", 1);
            graph.AddEdge("vertex1", "vertex3", 2);

            var cGraph = new ComputationGraph(graph);
            Assert.AreEqual(1, cGraph.GetEdgeLength(0, 1));
            Assert.AreEqual(2, cGraph.GetEdgeLength(0, 2));
            Assert.AreEqual(Double.PositiveInfinity, cGraph.GetEdgeLength(1, 2));
        }
        
    }
}