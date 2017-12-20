using System.Collections.Generic;
using FailureSimulator.Core.ComputationGraph;
using FailureSimulator.Core.Graph;
using FailureSimulator.Core.PathAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FailureSimulator.Tests
{
    [TestClass]
    public class DijkstraTests
    {
        [TestMethod]
        public void PathExists_firstToLast()
        {
            var graph = new Graph();
            graph.AddVertex(new Vertex("v1"));
            graph.AddVertex(new Vertex("v2"));
            graph.AddVertex(new Vertex("v3"));
            graph.AddVertex(new Vertex("v4"));
            graph.AddVertex(new Vertex("v5"));

            graph.AddEdge("v1", "v2", 2);
            graph.AddEdge("v1", "v3", 7);
            graph.AddEdge("v2", "v4", 8);
            graph.AddEdge("v3", "v4", 2);
            graph.AddEdge("v3", "v5", 10);
            graph.AddEdge("v4", "v5", 5);

            var cGraph = new ComputationGraph(graph);
            var dijstra = new DijkstraPathFinder();
            var path  = dijstra.GetPath(cGraph, 0, 4);

            CollectionAssert.AreEqual(new List<int>(){0,2,3,4}, path);
        }

        [TestMethod]
        public void PathExists_otherVertex()
        {
            var graph = new Graph();
            graph.AddVertex(new Vertex("v1"));
            graph.AddVertex(new Vertex("v2"));
            graph.AddVertex(new Vertex("v3"));
            graph.AddVertex(new Vertex("v4"));
            graph.AddVertex(new Vertex("v5"));

            graph.AddEdge("v1", "v2", 2);  graph.AddEdge("v2", "v1", 2);
            graph.AddEdge("v1", "v3", 7);  graph.AddEdge("v3", "v1", 7);
            graph.AddEdge("v2", "v4", 8);  graph.AddEdge("v4", "v2", 8);
            graph.AddEdge("v3", "v4", 2);  graph.AddEdge("v4", "v3", 2);
            graph.AddEdge("v3", "v5", 10); graph.AddEdge("v5", "v3", 10);
            graph.AddEdge("v4", "v5", 5);  graph.AddEdge("v5", "v4", 5);

            var cGraph = new ComputationGraph(graph);
            var dijstra = new DijkstraPathFinder();
            var path = dijstra.GetPath(cGraph, 1, 2);

            CollectionAssert.AreEqual(new List<int>() { 1, 0, 2 }, path);
        }

        [TestMethod]
        public void PathExists_noPath()
        {
            var graph = new Graph();
            graph.AddVertex(new Vertex("v1"));
            graph.AddVertex(new Vertex("v2"));
            graph.AddVertex(new Vertex("v3"));
            graph.AddVertex(new Vertex("v4"));
            graph.AddVertex(new Vertex("v5"));

            graph.AddEdge("v1", "v2", 2);
            graph.AddEdge("v1", "v3", 7);
            graph.AddEdge("v2", "v4", 8);
            graph.AddEdge("v3", "v4", 2);
            graph.AddEdge("v3", "v5", 10);
            graph.AddEdge("v4", "v5", 5);

            var cGraph = new ComputationGraph(graph);
            var dijstra = new DijkstraPathFinder();
            var path = dijstra.GetPath(cGraph, 1, 2);

            Assert.IsNull(path);
        }
    }
}