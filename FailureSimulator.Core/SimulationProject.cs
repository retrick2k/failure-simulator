using FailureSimulator.Core.Simulator;

namespace FailureSimulator.Core
{
    /// <summary>
    /// Сохраняет и сцену, и настройки
    /// </summary>
    public class SimulationProject
    {
        public Graph.Graph Graph { get; set; }
        public SimulationSettings SimulationSettings { get; set; }
    }
}