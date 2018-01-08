using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FailureSimulator.Core.Graph;
using FailureSimulator.Core.PathAlgorithms;
using FailureSimulator.Core.Simulator;

namespace FailureSimulator.Console
{
    class Program
    {
        static void Main(string[] args)
        {            
            var graph = new Graph();
            var v1  = graph.AddVertex(new Vertex("v1", 0));
            var v2 = graph.AddVertex(new Vertex("v2", 0));
            graph.AddVertex(new Vertex("v3", 0));
            graph.AddVertex(new Vertex("v4", 0));

            graph.AddEdge("v1", "v3", 0.00);
            graph.AddEdge("v1", "v4", 0.00);
            graph.AddEdge("v3", "v2", 0.00);
            graph.AddEdge("v4", "v2", 0.00);
            
            var sim = new Simulator(graph, new DfsPathFinder(), SimulationSettings.Default);
            var report = sim.Simulate(v1, v2);

            PrintValue("Min fail time", report.MinFailureTime);
            PrintValue("Max fail time", report.MaxFailureTime);
            PrintValue("Average fail time", report.AverageFailureTime);
            PrintValueNA("Average repair time");
            PrintValueNA("Availability rate");

            System.Console.WriteLine("Pathes:");
            foreach (var path in report.Pathes)
            {
                for(int i = 0; i < path.Count - 1; i++)
                    System.Console.Write(path[i].Name + " -> ");

                System.Console.WriteLine(path.Last().Name);                
            }

            System.Console.WriteLine("Failure bar chart:");
            foreach (var point in report.FailureBarChart)
            {
                System.Console.WriteLine($"{point.X,-10:0.###} {point.Y}");
            }

            PrintValueNA("Repair bar chart");
            PrintValueNA("Time diagram");
        }

        static void PrintValue(string name, double value)
        {
            System.Console.WriteLine("{0,-20}: {1:0.###}", name, value);
        }

        static void PrintValueNA(string name)
        {
            System.Console.WriteLine("{0,-20}: N/A", name);
        }
    }
}
