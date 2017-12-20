using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using FailureSimulator.Core.Graph;
using FailureSimulator.Core.PathAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FailureSimulator.Tests
{
    [TestClass]
    public class DfsTests
    {
        private PathComparer comparer;

        public DfsTests()
        {
            comparer = new PathComparer();
        }

        [TestMethod]
        public void FindPath_1()
        {
            var graph = new Graph();
            var v0 = graph.AddVertex(new Vertex("0"));
            var v1 = graph.AddVertex(new Vertex("1"));
            var v2 = graph.AddVertex(new Vertex("2"));
            var v3 = graph.AddVertex(new Vertex("3"));
            graph.AddEdge("0", "1");
            graph.AddEdge("0", "2");
            graph.AddEdge("2", "1");
            graph.AddEdge("1", "3");

            var pathfinder = new DfsPathFinder();
            var pathes = pathfinder.FindAllPathes(graph, "0", "3");
            var expectedPathes = new List<List<Vertex>>()
            {
                new List<Vertex>() {v0, v1, v3},
                new List<Vertex>() {v0, v2, v1, v3},
            };

            CollectionAssert.AreEqual(expectedPathes, pathes, comparer);
        }


        [TestMethod]
        public void FindPath_2()
        {
            var graph = new Graph();
            var v0 = graph.AddVertex(new Vertex("0"));
            var v1 = graph.AddVertex(new Vertex("1"));
            var v2 = graph.AddVertex(new Vertex("2"));
            var v3 = graph.AddVertex(new Vertex("3"));
            graph.AddEdge("0", "1"); graph.AddEdge("1", "0");
            graph.AddEdge("0", "2"); graph.AddEdge("2", "0");
            graph.AddEdge("2", "1"); graph.AddEdge("1", "2");
            graph.AddEdge("1", "3"); graph.AddEdge("3", "1");

            var pathfinder = new DfsPathFinder();
            var pathes = pathfinder.FindAllPathes(graph, "3", "2");
            var expectedPathes = new List<List<Vertex>>()
            {

                new List<Vertex>() {v3, v1, v0, v2},
                new List<Vertex>() {v3, v1, v2}
            };

            CollectionAssert.AreEqual(expectedPathes, (ICollection)pathes, comparer);
        }
    }



    // Такой вот костыль, потому что нормально сравнить вложенные коллекции неудобно
    class PathComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var pathX = (IReadOnlyList<Vertex>) x;
            var pathY = (IReadOnlyList<Vertex>) y;

            return pathX.SequenceEqual(pathY) ? 0 : 1;
        }
    }
}