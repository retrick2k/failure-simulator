using System.Collections.Generic;
using FailureSimulator.Core.Simulator.Report;

namespace FailureSimulator.Core.Simulator
{
    /// <summary>
    /// Результаты, имзмеренные одной итерацией
    /// </summary>
    public class IterationReport
    {
        public double FailureTime { get; set; }
        public List<double> RepairTimes { get; set; }
        public TimeDiagram TimeDiagram { get; set; }
    }
}