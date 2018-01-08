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

            var graph = new Graph();
            var start = graph.AddVertex(new Vertex("v1", 0));
            graph.AddVertex(new Vertex("v2", 0));
            graph.AddVertex(new Vertex("v3", 0));
            var end = graph.AddVertex(new Vertex("v4", 0));


            graph.AddEdge("v1", "v2", 0.5);
            graph.AddEdge("v2", "v4", 0.5);

            graph.AddEdge("v1", "v3", 0.5);
            graph.AddEdge("v3", "v4", 0.5);


            for(int i = 0; i<1; i++)
                graph.AddEdge("v1", "v4", 0.005);
            
            var sim = new Simulator(graph, new DfsPathFinder());
            var report = sim.Simulate(start, end, SimulationSettings.Default);

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


            foreach (var timeline in report.TimeDiagram)
            {
                Console.WriteLine($"{timeline.Key.Name}:");
                foreach (var e in timeline.Value)
                {
                    Console.WriteLine($"\t{e.State} at {e.Time}");
                }
                
            }
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
