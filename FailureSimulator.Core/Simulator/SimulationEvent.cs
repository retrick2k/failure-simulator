using System;

namespace FailureSimulator.Core.Simulator
{
    /// <summary>
    /// Событие при симуляции
    /// </summary>
    public class SimulationEvent : IComparable<SimulationEvent>
    {
        public EventType Type { get; set; }
        public double Time { get; set; }
        public DestroyableElement Element { get; set; }


        public int CompareTo(SimulationEvent other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return Time.CompareTo(other.Time);
        }
    }

    public enum EventType
    {
        FAILURE,
        REPAIR
    }
}