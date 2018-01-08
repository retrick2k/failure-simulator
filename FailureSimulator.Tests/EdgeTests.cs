using System;
using System.Linq;
using FailureSimulator.Core.Graph;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FailureSimulator.Tests
{
    [TestClass]
    public class EdgeTests
    {
        [TestMethod]
        public void CreateEdge_ok()
        {
            var from = new Vertex("from", 0);
            var vertex = new Vertex("vertex", 0);
            var edge = new Edge(from, vertex, 0.5);

            Assert.AreEqual(vertex, edge.VertexTo);            
            Assert.AreEqual(0.5, edge.FailIntensity);
        }
    }
}