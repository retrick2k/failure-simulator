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
            var from = new Vertex("from");
            var vertex = new Vertex("vertex");
            var edge = new Edge(from, vertex, 2, 0.5);

            Assert.AreEqual(vertex, edge.VertexTo);
            Assert.AreEqual(2, edge.Length);
            Assert.AreEqual(0.5, edge.SpecificFailIntensity);
        }


        [TestMethod]
        public void Intensity()
        {
            var from = new Vertex("from");
            var vertex = new Vertex("vertex");
            var edge = new Edge(from, vertex, 2, 0.5);

            Assert.AreEqual(2 * 0.5, edge.FailIntensity);
        }
    }
}