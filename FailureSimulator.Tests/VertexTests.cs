using System;
using System.Linq;
using FailureSimulator.Core.Graph;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FailureSimulator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateVertex_ok()
        {
            string name = "vertex";
            var vertex = new Vertex(name);
            Assert.AreEqual(name, vertex.Name);
        }

        [TestMethod]
        public void AddEdge_ok()
        {
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            var edge1 = vertex1.AddEdge(vertex2);

            var edge2 = vertex1.Edges[0];
            Assert.AreSame(edge2.VertexTo, vertex2);
            Assert.AreSame(edge1, edge2);
        }

        [TestMethod]
        public void RemoveEdge_byVertexRef_ok()
        {
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            vertex1.AddEdge(vertex2);

            vertex1.RemoveEdge(vertex2);
            Assert.AreEqual(0, vertex1.Edges.Count);
        }

        [TestMethod]
        public void RemoveEdge_byVertexRef_fail_edgeNull()
        {
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            vertex1.AddEdge(vertex2);
            
            Assert.ThrowsException<ArgumentNullException>(() => vertex1.RemoveEdge(null as Vertex));
        }

        [TestMethod]
        public void RemoveEdge_byVertexRef_fail_noEdge()
        {
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            var vertex3 = new Vertex("vertex3");
            vertex1.AddEdge(vertex2);

            Assert.ThrowsException<ArgumentException>(() => vertex1.RemoveEdge(vertex3));
        }

        [TestMethod]
        public void RemoveEdge_byVertexName_ok()
        {
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            vertex1.AddEdge(vertex2);

            vertex1.RemoveEdge("vertex2");
            Assert.AreEqual(0, vertex1.Edges.Count);
        }

        [TestMethod]
        public void RemoveEdge_byVertexName_fail_vertexNull()
        {
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            vertex1.AddEdge(vertex2);

            Assert.ThrowsException<ArgumentNullException>(() => vertex1.RemoveEdge(null as string));
        }

        [TestMethod]
        public void RemoveEdge_byVertexName_fail_noEdge()
        {
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            vertex1.AddEdge(vertex2);

            Assert.ThrowsException<ArgumentException>(() => vertex1.RemoveEdge("vertex3"));
        }

        [TestMethod]
        public void RemoveEdge_byEdgeRef_ok()
        {
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            var edge = vertex1.AddEdge(vertex2);
            vertex1.RemoveEdge(edge);

            Assert.AreEqual(0, vertex1.Edges.Count);
        }

        [TestMethod]
        public void RemoveEdge_byEdgeRef_fail_edgeNull()
        {
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            vertex1.AddEdge(vertex2);

            Assert.ThrowsException<ArgumentNullException>(() => vertex1.RemoveEdge(null as Edge));
        }

        [TestMethod]
        public void RemoveEdge_byEdgeRef_fail_noEdge()
        {
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            vertex1.AddEdge(vertex2);

            var edge = new Edge(vertex1, new Vertex("vertex3"));
            Assert.ThrowsException<ArgumentException>(() => vertex1.RemoveEdge(edge));
        }


        [TestMethod]
        public void GetEdge_byVertexName_ok()
        {
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            var edge1 = vertex1.AddEdge(vertex2);
            var edge2 = vertex1.GetEdge("vertex2");

            Assert.AreSame(edge1, edge2);
        }

        [TestMethod]
        public void GetEdge_byVertexName_fail_noVertex()
        {
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            vertex1.AddEdge(vertex2);

            var edge = vertex1.GetEdge("vertex3");
            Assert.IsNull(edge);
        }

        [TestMethod]
        public void GetEdge_byVertexName_fail_vertexNull()
        {
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            vertex1.AddEdge(vertex2);

            Assert.ThrowsException<ArgumentNullException>(() => vertex1.GetEdge(null as string));
        }

        [TestMethod]
        public void GetEdge_byVertexRef_ok()
        {
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            var edge1 = vertex1.AddEdge(vertex2);
            var edge2 = vertex1.GetEdge(vertex2);

            Assert.AreSame(edge1, edge2);
        }

        [TestMethod]
        public void GetEdge_byVertexRef_fail_noVertex()
        {
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            vertex1.AddEdge(vertex2);

            var edge = vertex1.GetEdge(new Vertex("vertex3"));
            Assert.IsNull(edge);
        }

        [TestMethod]
        public void GetEdge_byVertexRef_fail_vertexNull()
        {
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            vertex1.AddEdge(vertex2);

            Assert.ThrowsException<ArgumentNullException>(() => vertex1.GetEdge(null as Vertex));
        }
    }
}
