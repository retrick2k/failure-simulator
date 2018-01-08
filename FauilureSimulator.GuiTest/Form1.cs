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
using Point = FailureSimulator.Core.Simulator.Report.Point;

namespace FauilureSimulator.GuiTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var e1 = new Element("e1", 0.01);

            var graph = new Graph();
            var start = graph.AddVertex(new Vertex("v1"));
            graph.AddVertex(new Vertex("v2"));
            graph.AddVertex(new Vertex("v3"));
            var end = graph.AddVertex(new Vertex("v4"));


            graph.AddEdge("v1", "v2", 1, 0.5);
            graph.AddEdge("v2", "v4", 1, 0.5);

            graph.AddEdge("v1", "v3", 1, 0.5);
            graph.AddEdge("v3", "v4", 1, 0.5);


            for(int i = 0; i<1; i++)
                graph.AddEdge("v1", "v4", 1, 0.005);
            
            var sim = new Simulator(graph, new DfsPathFinder(), SimulationSettings.Default);
            var report = sim.Simulate(start, end);

            PrintValue("Min fail time", report.MinFailureTime);
            PrintValue("Max fail time", report.MaxFailureTime);
            PrintValue("Average fail time", report.AverageFailureTime);
            PrintValue("Average repair time", report.AverageRepairTime);
            PrintValue("Availability rate", report.AvailabilityRate);

            Console.WriteLine("Pathes:");
            foreach (var path in report.Pathes)
            {
                for (int i = 0; i < path.Count - 1; i++)
                    Console.Write(path[i].Name + " -> ");

                Console.WriteLine(path.Last().Name);
            }
            
            PrintValueNA("Repair bar chart");
            PrintValueNA("Time diagram");

            PlotHist(zedGraphControl1, report.FailureBarChart);
            PlotHist(zedGraphControl2, report.RepairBarChart);
        }

        private void PlotHist(ZedGraphControl graph, Point[] data)
        {
            if (data == null)
                return;

            var points = new PointPairList();
            foreach (var p in data)
            {
                points.Add(p.X, p.Y);
            }

            var pane = graph.GraphPane;
            pane.BarSettings.MinClusterGap = 0;
            pane.BarSettings.MinBarGap = 0;
            pane.AddBar("WTF", points, Color.Green);

            graph.AxisChange();
            graph.Invalidate();
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
