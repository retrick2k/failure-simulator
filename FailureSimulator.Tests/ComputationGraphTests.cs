using FailureSimulator.Core.Graph;
using FailureSimulator.Core.PathAlgorithms;
using FailureSimulator.Core.Simulator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FailureSimulator.Tests
{
    [TestClass]
    public class ComputationGraphTests
    {
        [TestMethod]
        public void TestEcnounters()
        {
            var graph = new Graph();
            var v1 = graph.AddVertex(new Vertex("v1"));
            var v2 = graph.AddVertex(new Vertex("v2"));
            var v3 = graph.AddVertex(new Vertex("v3"));
            var v4 = graph.AddVertex(new Vertex("v4"));

            var v1v2 = graph.AddEdge("v1", "v2");
            var v2v4 = graph.AddEdge("v2", "v4");

            var v1v3 = graph.AddEdge("v1", "v3");
            var v3v4 = graph.AddEdge("v3", "v4");

            var cGraph = new ComputationGraph(graph, new DfsPathFinder(), v1, v4);

            Assert.AreEqual(2, cGraph.Elements[v1].EncountsCount);
            Assert.AreEqual(1, cGraph.Elements[v2].EncountsCount);
            Assert.AreEqual(1, cGraph.Elements[v3].EncountsCount);
            Assert.AreEqual(2, cGraph.Elements[v4].EncountsCount);

            Assert.AreEqual(1, cGraph.Elements[v1v2].EncountsCount);
            Assert.AreEqual(1, cGraph.Elements[v2v4].EncountsCount);
            Assert.AreEqual(1, cGraph.Elements[v1v3].EncountsCount);
            Assert.AreEqual(1, cGraph.Elements[v3v4].EncountsCount);
        }
    }
}