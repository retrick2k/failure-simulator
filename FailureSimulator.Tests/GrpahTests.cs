using System;
using System.Linq;
using FailureSimulator.Core.Graph;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FailureSimulator.Tests
{
    [TestClass]
    public class GrpahTests
    {
        [TestMethod]
        public void CreateGraph_ok()
        {
            var graph = new Graph();
            Assert.AreEqual(0, graph.Vertex.Count);
            Assert.AreEqual(0, graph.Elements.Count);
        }

        [TestMethod]
        public void AddVertex_ok()
        {
            var graph = new Graph();
            var vertex = new Vertex("vertex1");
            graph.AddVertex(vertex);

            Assert.AreSame(vertex, graph.Vertex[0]);
        }

        [TestMethod]
        public void AddVertex_fail_refAlreadyExists()
        {
            var graph = new Graph();
            var vertex = new Vertex("vertex1");
            graph.AddVertex(vertex);

            Assert.ThrowsException<ArgumentException>(() => graph.AddVertex(vertex));
        }

        [TestMethod]
        public void AddVertex_fail_nameAlreadyExists()
        {
            var graph = new Graph();
            var vertex = new Vertex("vertex1");
            graph.AddVertex(vertex);

            Assert.ThrowsException<ArgumentException>(() => graph.AddVertex(new Vertex("vertex1")));
        }

        [TestMethod]
        public void AddEdge_byVertexRef_ok()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            graph.AddVertex(vertex1);
            graph.AddVertex(vertex2);

            var edge1 = graph.AddEdge(vertex1, vertex2);
            Assert.AreSame(edge1, graph.Vertex[0].Edges[0]);
            Assert.AreSame(vertex2, graph.Vertex[0].Edges[0].VertexTo);
            Assert.AreEqual(1, graph.Vertex[0].Edges.Count);
        }

        [TestMethod]
        public void AddEdge_byVertexRef_ok_sameNameDifferentRefs()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            graph.AddVertex(vertex1);
            graph.AddVertex(new Vertex("vertex2"));

            var edge1 = graph.AddEdge(vertex1, vertex2);
            Assert.AreSame(edge1, graph.Vertex[0].Edges[0]);
            Assert.AreSame(vertex2, graph.Vertex[0].Edges[0].VertexTo);
            Assert.AreEqual(1, graph.Vertex[0].Edges.Count);
        }

        [TestMethod]
        public void AddEdge_byVertexRef_fail_vertexNull()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            graph.AddVertex(vertex1);
            graph.AddVertex(vertex2);

            Assert.ThrowsException<ArgumentNullException>(() => graph.AddEdge(null as Vertex, vertex2));
            Assert.ThrowsException<ArgumentNullException>(() => graph.AddEdge(vertex1, null as Vertex));
            Assert.ThrowsException<ArgumentNullException>(() => graph.AddEdge(null as Vertex, null as Vertex));
        }


        [TestMethod]
        public void AddEdge_byVertexRef_fail_noVertex()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            var vertex3  = new Vertex("vertex3");
            graph.AddVertex(vertex1);
            graph.AddVertex(vertex2);

            Assert.ThrowsException<ArgumentException>(() => graph.AddEdge(vertex3, vertex2));
            Assert.ThrowsException<ArgumentException>(() => graph.AddEdge(vertex1, vertex3));
            Assert.ThrowsException<ArgumentException>(() => graph.AddEdge(vertex3, vertex3));
        }

        [TestMethod]
        public void AddEdge_byVertexName_ok()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            graph.AddVertex(vertex1);
            graph.AddVertex(vertex2);

            var edge1 = graph.AddEdge("vertex1", "vertex2");
            Assert.AreSame(edge1, graph.Vertex[0].Edges[0]);
            Assert.AreSame(vertex2, graph.Vertex[0].Edges[0].VertexTo);
            Assert.AreEqual(1, graph.Vertex[0].Edges.Count);
        }

        [TestMethod]
        public void AddEdge_byVertexName_fail_vertexNameNull()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            graph.AddVertex(vertex1);
            graph.AddVertex(vertex2);

            Assert.ThrowsException<ArgumentNullException>(() => graph.AddEdge(null as string, "vertex2"));
            Assert.ThrowsException<ArgumentNullException>(() => graph.AddEdge("vertex1", null as string));
            Assert.ThrowsException<ArgumentNullException>(() => graph.AddEdge(null as string, null as string));
        }

        [TestMethod]
        public void AddEdge_byVertexName_fail_noVertex()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            graph.AddVertex(vertex1);
            graph.AddVertex(vertex2);

            Assert.ThrowsException<ArgumentException>(() => graph.AddEdge("vertex3", "vertex2"));
            Assert.ThrowsException<ArgumentException>(() => graph.AddEdge("vertex1", "vertex3"));
            Assert.ThrowsException<ArgumentException>(() => graph.AddEdge("vertex3", "vertex4"));
        }

        [TestMethod]
        public void RemoveVertex_byVertexRef_ok_noEdge()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            graph.AddVertex(vertex1);

            graph.RemoveVertex(vertex1);
            Assert.AreEqual(0, graph.Vertex.Count);
        }

        [TestMethod]
        public void RemoveVertex_byVertexRef_ok_removeEdge()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            graph.AddVertex(vertex1);
            graph.AddVertex(vertex2);
            graph.AddEdge(vertex2, vertex1);

            graph.RemoveVertex(vertex1);
            Assert.AreEqual(1, graph.Vertex.Count);
            Assert.AreSame(vertex2, graph.Vertex[0]);
            Assert.AreEqual(0, graph.Vertex[0].Edges.Count); // Ребра 2-1 нет
        }

        [TestMethod]
        public void RemoveVertex_byVertexRef_ok_removeMultipleEdges()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            var vertex3 = new Vertex("vertex3");
            graph.AddVertex(vertex1);
            graph.AddVertex(vertex2);
            graph.AddVertex(vertex3);
            graph.AddEdge(vertex2, vertex1);
            graph.AddEdge(vertex3, vertex1);

            graph.RemoveVertex(vertex1);
            Assert.AreEqual(2, graph.Vertex.Count);
            Assert.AreEqual(0, graph.Vertex[0].Edges.Count); // Ребра 2-1 нет
            Assert.AreEqual(0, graph.Vertex[1].Edges.Count); // Ребра 3-1 нет
        }

        [TestMethod]
        public void RemoveVertex_byVertexRef_ok_keepOtherEdges()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            var vertex3 = new Vertex("vertex3");
            graph.AddVertex(vertex1);
            graph.AddVertex(vertex2);
            graph.AddVertex(vertex3);
            graph.AddEdge(vertex2, vertex1);
            graph.AddEdge(vertex3, vertex2);

            graph.RemoveVertex(vertex1);
            Assert.AreEqual(2, graph.Vertex.Count);
            Assert.AreEqual(0, graph.Vertex[0].Edges.Count); // Ребра 2-1 нет
            Assert.AreEqual(1, graph.Vertex[1].Edges.Count); // Ребро 3-2
        }

        // Даже не знаю, какое поведение правильное
        [TestMethod]
        public void RemoveVertex_byVertexRef_ok_sameNameDifferentRefs()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            graph.AddVertex(vertex1);
            graph.AddVertex(vertex2);
            graph.AddEdge(vertex2, vertex1);

            graph.RemoveVertex(new Vertex("vertex2"));
            Assert.AreEqual(1, graph.Vertex.Count);
            Assert.AreSame(vertex2, graph.Vertex[0]);
            Assert.AreEqual(0, graph.Vertex[0].Edges.Count); // Ребра 2-1 нет
        }

        [TestMethod]
        public void RemoveVertex_byVertexRef_fail_vertexNull()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            graph.AddVertex(vertex1);
            graph.AddVertex(vertex2);
            graph.AddEdge(vertex2, vertex1);

            Assert.ThrowsException<ArgumentNullException>(() => graph.RemoveVertex(null as Vertex));
        }

        [TestMethod]
        public void RemoveVertex_byVertexRef_fail_noVertex()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            var vertex2 = new Vertex("vertex2");
            graph.AddVertex(vertex1);
            graph.AddVertex(vertex2);
            graph.AddEdge(vertex2, vertex1);
            
            Assert.ThrowsException<ArgumentException>(() => graph.RemoveVertex(new Vertex("vertex3")));
        }

        //TODO: Тест удаление по строкам
        //TODO: Тест удаления ребер ссылками
        //TODO: Тест удаления ребер строками

        [TestMethod]
        public void GetVertexByName_ok()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            graph.AddVertex(vertex1);

            var vertex2 = graph.GetVertex("vertex1");
            Assert.AreSame(vertex1, vertex2);
        }

        [TestMethod]
        public void GetVertexByName_fail_noVertex()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            graph.AddVertex(vertex1);

            var vertex2 = graph.GetVertex("vertex2");
            Assert.IsNull(vertex2);
        }


        [TestMethod]
        public void GetVertexIndex_byVertexRef_ok()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            graph.AddVertex(vertex1);

            Assert.AreEqual(0, graph.GetVertexIndex(vertex1));
        }

        [TestMethod]
        public void GetVertexIndex_byVertexRef_ok_sameNameDifferentRefs()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            graph.AddVertex(vertex1);

            Assert.AreEqual(0, graph.GetVertexIndex(new Vertex("vertex1")));
        }

        [TestMethod]
        public void GetVertexIndex_byVertexRef_fail_vertexNull()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            graph.AddVertex(vertex1);

            Assert.ThrowsException<ArgumentNullException>(() => graph.GetVertexIndex(null as Vertex));
        }

        [TestMethod]
        public void GetVertexIndex_byVertexRef_fail_noVertex()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            graph.AddVertex(vertex1);

            Assert.ThrowsException<ArgumentException>(() => graph.GetVertexIndex(new Vertex("vertex2")));
        }
        
        [TestMethod]
        public void GetVertexIndex_byVertexName_ok()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            graph.AddVertex(vertex1);

            Assert.AreEqual(0, graph.GetVertexIndex("vertex1"));
        }

        [TestMethod]
        public void GetVertexIndex_byVertexName_fail_vertexNameNull()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            graph.AddVertex(vertex1);

            Assert.ThrowsException<ArgumentNullException>(() => graph.GetVertexIndex(null as string));
        }

        [TestMethod]
        public void GetVertexIndex_byVertexName_fail_noVertex()
        {
            var graph = new Graph();
            var vertex1 = new Vertex("vertex1");
            graph.AddVertex(vertex1);

            Assert.ThrowsException<ArgumentException>(() => graph.GetVertexIndex("vertex2"));
        }
    }
}