using FailureSimulator.Core.Graph;
using FailureSimulator.Core.PathAlgorithms;
using FailureSimulator.Core.Simulator;
using FailureSimulator.Core.Simulator.Report;
using FailureSimulator.GUI.Helpers;
using GraphX.Controls;
using GraphX.Controls.Models;
using GraphX.PCL.Common.Enums;
using GraphX.PCL.Logic.Algorithms.OverlapRemoval;
using GraphX.PCL.Logic.Models;
using QuickGraph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace FailureSimulator.GUI
{
    public partial class Form1 : Form
    {
        private DataGraph _vGraph;
        private ZoomControl _zoomctrl;
        private MGraphArea _gArea;
        private Graph TestingSystem;
        private Vertex StartVertex;
        private Vertex FinishVertex;
        private SimulationReport LastSimulationReport;

        public Form1()
        {
            InitializeComponent();
            CreateGraphX();                
        }

        private void сохранитьОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Создает контрол графа
        void CreateGraphX()
        {
            _zoomctrl = new ZoomControl();
            ZoomControl.SetViewFinderVisibility(_zoomctrl, Visibility.Visible);
            var logic = new GXLogicCore<DataVertex, DataEdge, BidirectionalGraph<DataVertex, DataEdge>>();
            logic.DefaultLayoutAlgorithm = LayoutAlgorithmTypeEnum.LinLog;
            logic.DefaultLayoutAlgorithmParams = logic.AlgorithmFactory.CreateLayoutParameters(LayoutAlgorithmTypeEnum.LinLog);
            logic.DefaultOverlapRemovalAlgorithm = OverlapRemovalAlgorithmTypeEnum.FSA;
            logic.DefaultOverlapRemovalAlgorithmParams = logic.AlgorithmFactory.CreateOverlapRemovalParameters(OverlapRemovalAlgorithmTypeEnum.FSA);
            ((OverlapRemovalParameters)logic.DefaultOverlapRemovalAlgorithmParams).HorizontalGap = 50;
            ((OverlapRemovalParameters)logic.DefaultOverlapRemovalAlgorithmParams).VerticalGap = 50;
            logic.DefaultEdgeRoutingAlgorithm = EdgeRoutingAlgorithmTypeEnum.None;
            logic.AsyncAlgorithmCompute = false;
            _zoomctrl.Content = _gArea;

            _gArea = new MGraphArea()
            {
                // EnableWinFormsHostingMode = false,
                LogicCore = logic,
                EdgeLabelFactory = new DefaultEdgelabelFactory()
            };

            _gArea.ShowAllEdgesLabels(false);
            _zoomctrl.Content = _gArea;
            graphHost.Child = _zoomctrl;

            _gArea.VertexSelected += _gArea_VertexSelected;
            _gArea.EdgeSelected += _gArea_EdgeSelected;

            _gArea.SetVerticesDrag(true, true);
            _zoomctrl.ZoomToFill();

            _vGraph = new DataGraph();
            logic.Graph = _vGraph;
        }

        private void _gArea_EdgeSelected(object sender, EdgeSelectedEventArgs args)
        {
            var selectedEdge = (args.EdgeControl.Edge as DataEdge).Edge;
            tbEdgeFailIntensity.Text = selectedEdge.FailIntensity.ToString();
        }

        private void _gArea_VertexSelected(object sender, VertexSelectedEventArgs args)
        {
            var selectedVertex = (args.VertexControl.Vertex as DataVertex).Vertex;
            if (gbVertexChoosingMode.Enabled)
            {
                if (rbSelectStartVertex.Checked)
                {
                    StartVertex = selectedVertex;
                    tbStartVertex.Text = StartVertex.Name;
                }
                else
                {
                    FinishVertex = selectedVertex;
                    tbFinishVertex.Text = FinishVertex.Name;
                }
            }
            tbVertexNameCh.Text = selectedVertex.Name;
            tbVertexFailIntensity.Text = selectedVertex.FailIntensity.ToString();
        }        

        // Отображает граф
        private void ShowGraph(Graph graph)
        {
            _vGraph.Clear();

            foreach (var vertex in graph.Vertex)
            {
                var dv1 = _vGraph.AddVertexIfNotExists(vertex);

                foreach (var edge in vertex.Edges)
                {
                    var dv2 = _vGraph.AddVertexIfNotExists(edge.VertexTo);
                    _vGraph.AddEdge(new DataEdge(edge, dv1, dv2));
                }
            }

            _gArea.GenerateGraph(true);

        }

        /// <summary>
        /// Создать граф с топологией "Шина"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void шинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestingSystem = new Graph();
            var A = TestingSystem.AddVertex(new Vertex("A", 0.35));
            var B = TestingSystem.AddVertex(new Vertex("B", 0.123));
            var C = TestingSystem.AddVertex(new Vertex("C", 0.228));
            var D = TestingSystem.AddVertex(new Vertex("D", 0.0001));
            var E = TestingSystem.AddVertex(new Vertex("E", 0.1));      

            TestingSystem.AddEdge(A.Name, B.Name, 0.12);
            TestingSystem.AddEdge(B.Name, C.Name, 0.5);
            TestingSystem.AddEdge(C.Name, D.Name, 0.89);
            TestingSystem.AddEdge(D.Name, E.Name, 0.5);

            ShowGraph(TestingSystem);
        }

        private void запуститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sim = new Simulator(new DfsPathFinder());
            LastSimulationReport = sim.Simulate(TestingSystem, StartVertex, FinishVertex, SimulationSettings.Default);
            ShowLastReport();
        }

        private void ShowLastReport()
        {
            // Замеры
            tbMinFailureTime.Text = LastSimulationReport.MinFailureTime.ToString();
            tbMaxFailureTime.Text = LastSimulationReport.MaxFailureTime.ToString();
            tbAverageFailureTime.Text = LastSimulationReport.AverageFailureTime.ToString();
            tbAverageRepairTime.Text = LastSimulationReport.AverageRepairTime.ToString();
            tbAvailabilityRate.Text = LastSimulationReport.AvailabilityRate.ToString();

            // Список путей
            lbPaths.Items.Clear();                        
            foreach (var path in LastSimulationReport.Pathes)
            {
                var pathStr = string.Empty;
                for (int i = 0; i < path.Count - 1; i++)
                {
                    pathStr += path[i].Name + " -> ";
                }
                pathStr += path[path.Count - 1].Name;
                lbPaths.Items.Add(pathStr);
            }
        }

        private void graphHost_Move(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cbVertexChoosingMode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVertexChoosingMode.Checked)
            {
                gbVertexChoosingMode.Enabled = true;
            }
            else
            {
                gbVertexChoosingMode.Enabled = false;
            }
        }
    }
}
