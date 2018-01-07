using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FailureSimulator.Core.Graph;
using FailureSimulator.Core.PathAlgorithms;
using FailureSimulator.Core.Simulator;
using ZedGraph;

namespace FauilureSimulator.GuiTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var e1 = new Element("e1", 0.001);

            var graph = new Graph();
            var v1 = graph.AddVertex(new Vertex("v1"));
            var v2 = graph.AddVertex(new Vertex("v2"));
            graph.AddVertex(new Vertex("v3"));
            graph.AddVertex(new Vertex("v4"));

            graph.Vertex[2].Elements.Add((e1, 1));
            graph.Vertex[3].Elements.Add((e1, 1));

            graph.AddEdge("v1", "v3", 1, 0.00);
            graph.AddEdge("v1", "v4", 1, 0.00);
            graph.AddEdge("v3", "v2", 1, 0.00);
            graph.AddEdge("v4", "v2", 1, 0.00);

            var sim = new Simulator(graph, new DfsPathFinder(), SimulationSettings.Default);
            var report = sim.Simulate(v1, v2);

            PrintValue("Min fail time", report.MinFailureTime);
            PrintValue("Max fail time", report.MaxFailureTime);
            PrintValue("Average fail time", report.AverageFailureTime);
            PrintValueNA("Average repair time");
            PrintValueNA("Availability rate");

            Console.WriteLine("Pathes:");
            foreach (var path in report.Pathes)
            {
                for (int i = 0; i < path.Count - 1; i++)
                    Console.Write(path[i].Name + " -> ");

                Console.WriteLine(path.Last().Name);
            }
            
            PrintValueNA("Repair bar chart");
            PrintValueNA("Time diagram");

            var points = new PointPairList();
            foreach (var p in report.FailureBarChart)
            {
                points.Add(p.X, p.Y);
            }

            var pane = zedGraphControl1.GraphPane;
            pane.AddBar("WTF", points, Color.Green);

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        static void PrintValue(string name, double value)
        {
            Console.WriteLine("{0,-20}: {1:0.###}", name, value);
        }

        static void PrintValueNA(string name)
        {
            Console.WriteLine("{0,-20}: N/A", name);
        }
    }
}
